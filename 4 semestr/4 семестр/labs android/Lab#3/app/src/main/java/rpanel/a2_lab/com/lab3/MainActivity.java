package rpanel.a2_lab.com.lab3;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.Button;

public class MainActivity extends AppCompatActivity {

  Button dataAct;
  Button timeAct;
  Button finish;

  @Override
  protected void onCreate(Bundle savedInstanceState) {
    super.onCreate(savedInstanceState);
    setContentView(R.layout.activity_main);

    dataAct = (Button) findViewById(R.id.button);
    timeAct = (Button) findViewById(R.id.button2);
    finish = (Button) findViewById(R.id.button3);

    dataAct.setOnClickListener(new OnClickListener() {
      @Override
      public void onClick(View view) {
        startActivity(new Intent(getApplicationContext(), DateActivity.class));
      }
    });
    timeAct.setOnClickListener(new OnClickListener() {
      @Override
      public void onClick(View view) {
        startActivity(new Intent(getApplicationContext(), TimeActivity.class));
      }
    });
    finish.setOnClickListener(new OnClickListener() {
      @Override
      public void onClick(View view) {
        finish();
      }
    });
  }
}
