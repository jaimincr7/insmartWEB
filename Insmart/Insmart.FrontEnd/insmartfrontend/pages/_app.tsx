import type { AppProps } from "next/app";
import "slick-carousel/slick/slick.css";
import "slick-carousel/slick/slick-theme.css";
import "../public/assets/css/color.css";
import "../public/assets/css/main.css";
import "../public/assets/css/responsive.css";
import { Provider } from "react-redux";
import { store } from "../utils/store";

export default function App({ Component, pageProps }: AppProps) {
  return (<Provider store={store}>
    <Component {...pageProps} />
  </Provider>);
}
