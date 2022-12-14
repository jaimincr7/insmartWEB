import { configureStore, ThunkAction, Action } from '@reduxjs/toolkit';
import promotionalsReducer from '../store/home/promotionalSlice';
import testimonialsReducer from '../store/home/testimonialSlice';
import bannersReducer from '../store/home/bannerSlice';
import doctorsListReducer from '../store/doctorList/doctorListSlice';
import specialitiesListReducer from '../store/specialitiesList/specialitiesListSlice';
import symptomsListReducer from '../store/symptomsList/symptomsListSlice';

export const store = configureStore({
  reducer: {
    promotionals: promotionalsReducer,
    testimonials: testimonialsReducer,
    banners: bannersReducer,
    doctorsList: doctorsListReducer,
    specialitiesList: specialitiesListReducer,
    symptomsList: symptomsListReducer,
  },
});

export type AppDispatch = typeof store.dispatch;
export type RootState = ReturnType<typeof store.getState>;
export type AppThunk<ReturnType = void> = ThunkAction<
  ReturnType,
  RootState,
  unknown,
  Action<string>
>;
