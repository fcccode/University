package tesseract.ddnsking.com.lab71;

import android.os.Bundle;
import android.support.v4.app.Fragment;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;
import android.widget.TextView;
import android.widget.Toast;
import org.jetbrains.annotations.Nullable;

public class TabFragment extends Fragment {
  String thematics;
  TextView txt;
  ImageView img1;
  ImageView img2;
  ImageView img3;
  ImageView img4;
  int imgi1;
  int imgi2;
  int imgi3;
  int imgi4;
  @Override
  public View onCreateView(LayoutInflater inflater, @Nullable ViewGroup container, @Nullable Bundle savedInstanceState) {
    View view = inflater.inflate(R.layout.tab_fragment, container, false);

    img1 = (ImageView) view.findViewById(R.id.imageView3);
    img2 = (ImageView) view.findViewById(R.id.imageView4);
    img3 = (ImageView) view.findViewById(R.id.imageView5);
    img4 = (ImageView) view.findViewById(R.id.imageView6);
    txt =(TextView) view.findViewById(R.id.textView);
    try{
      img1.setImageResource(imgi1);
      img2.setImageResource(imgi2);
      img3.setImageResource(imgi3);
      img4.setImageResource(imgi4);
      txt.setText(thematics);
    }catch (OutOfMemoryError e){
      Toast.makeText(getActivity(), "OutOfMemory", Toast.LENGTH_SHORT).show();
    }
    return view;
  }
  public TabFragment( String thematics, int img1, int img2, int img3, int img4){
    this.thematics = thematics;
    this.imgi1 = img1;
    this.imgi2 = img2;
    this.imgi3 = img3;
    this.imgi4 = img4;
  }
}
