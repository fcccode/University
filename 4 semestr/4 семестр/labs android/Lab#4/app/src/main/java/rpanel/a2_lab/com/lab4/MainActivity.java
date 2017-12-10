package rpanel.a2_lab.com.lab4;

import android.content.Intent;
import android.content.SharedPreferences;
import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.Button;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {

  TextView txt;
  Button btn;
  Button btn2;
  SharedPreferences sPref;

  @Override
  protected void onCreate(Bundle savedInstanceState) {
    super.onCreate(savedInstanceState);
    setContentView(R.layout.activity_main);
    txt = (TextView) findViewById(R.id.textView);
    btn = (Button) findViewById(R.id.button);
    btn2 = (Button) findViewById(R.id.button2);

    sPref = getSharedPreferences("myPref",MODE_PRIVATE);
    String savedText = sPref.getString("jsabg3huiHHS4352bgkjsdug364HASKjgnjds1", "");
    txt.setText(savedText);

    btn.setOnClickListener(new OnClickListener() {
      @Override
      public void onClick(View view) {
        startActivity(new Intent(getApplicationContext(),DataActivity.class));
        finish();
      }
    });
    btn2.setOnClickListener(new OnClickListener() {
      @Override
      public void onClick(View view) {
        finish();
      }
    });
  }
}
