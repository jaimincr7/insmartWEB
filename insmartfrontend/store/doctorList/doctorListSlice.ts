import { createAsyncThunk, createSlice, PayloadAction } from '@reduxjs/toolkit';
import testimonialsService from '../../services/homeServices/testimonialsService';
import { RootState } from '../../utils/store';

export interface DoctorsListState {
  value: number;
  status: 'idle' | 'loading' | 'failed';
  data: {
    status: String;
    doctorsList: any;
  };
}

const initialState: DoctorsListState = {
  value: 0,
  status: 'idle',
  data: {
    status: 'idle',
    doctorsList: [],
  }
};

export const getAllDoctorsListAction = createAsyncThunk(
  'getAllDoctorsListAction',
  async () => {
    const response = await testimonialsService.getAllTestimonials();
    return response.data;
  }
);

export const doctorsList = createSlice({
  name: 'doctorsList',
  initialState,
  reducers: {
    clearData: (state) => {
      state.data.doctorsList = [];
    },
  },
  extraReducers: (builder) => {
    builder
      .addCase(getAllDoctorsListAction.pending, (state) => {
        state.status = 'loading';
      })
      .addCase(getAllDoctorsListAction.fulfilled, (state, action) => {
        state.status = 'idle';
        state.data.doctorsList = action.payload.doctorsList;
      })
      .addCase(getAllDoctorsListAction.rejected, (state) => {
        state.status = 'failed';
      });
  },
});

export const { clearData } = doctorsList.actions;

export const testimonialSelector = (state: RootState) => state.doctorsList;

export default doctorsList.reducer;
