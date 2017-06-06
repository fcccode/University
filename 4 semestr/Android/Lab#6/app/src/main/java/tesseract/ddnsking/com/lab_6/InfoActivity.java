package tesseract.ddnsking.com.lab_6;

import android.content.Intent;
import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.widget.ImageView;
import android.widget.TextView;

public class InfoActivity extends AppCompatActivity {


  TextView txt;

  ImageView img1;
  ImageView img2;
  ImageView img3;
  ImageView img4;

  @Override
  protected void onCreate(Bundle savedInstanceState) {
    super.onCreate(savedInstanceState);
    setContentView(R.layout.activity_info);
    txt = (TextView) findViewById(R.id.textView);


    img1 = (ImageView) findViewById(R.id.imageView3);
    img2 = (ImageView) findViewById(R.id.imageView4);
    img3 = (ImageView) findViewById(R.id.imageView5);
    img4 = (ImageView) findViewById(R.id.imageView6);

    Intent intent = getIntent();


    txt.setText(intent.getStringExtra("text"));

    img1.setImageResource(intent.getIntExtra("pic_1",0));
    img2.setImageResource(intent.getIntExtra("pic_2",0));
    img3.setImageResource(intent.getIntExtra("pic_3",0));
    img4.setImageResource(intent.getIntExtra("pic_4",0));

  }
}