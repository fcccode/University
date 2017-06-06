package rpanel.a2_lab.com.lab_5;

import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.support.v7.widget.DefaultItemAnimator;
import android.support.v7.widget.LinearLayoutManager;
import android.support.v7.widget.RecyclerView;
import android.view.View;
import android.widget.Toast;
import java.util.ArrayList;
import java.util.List;
import rpanel.a2_lab.com.lab_5.RecyclerItemClickListener.OnItemClickListener;

public class MainActivity extends AppCompatActivity {

  private List<ListItem> mList = new ArrayList<>();
  private RecyclerView recyclerView;
  private Adapter mAdapter;

  @Override
  protected void onCreate(Bundle savedInstanceState) {
    super.onCreate(savedInstanceState);
    setContentView(R.layout.activity_main);

    recyclerView = (RecyclerView) findViewById(R.id.recycler_view);

    mAdapter = new Adapter(mList);
    RecyclerView.LayoutManager mLayoutManager = new LinearLayoutManager(getApplicationContext());
    recyclerView.setLayoutManager(mLayoutManager);
    recyclerView.setItemAnimator(new DefaultItemAnimator());
    recyclerView.setAdapter(mAdapter);
    recyclerView.addOnItemTouchListener(new RecyclerItemClickListener(getApplicationContext(),
        recyclerView, new OnItemClickListener() {
      @Override
      public void onItemClick(View view, int position) {
        switch (position){
          case 0:
            Toast.makeText(MainActivity.this, "You choose the game item ", Toast.LENGTH_SHORT).show();
            break;
          case 1:
            Toast.makeText(MainActivity.this, "You choose the flower item", Toast.LENGTH_SHORT).show();
            break;
          case 2:
            Toast.makeText(MainActivity.this, "You choose the car item", Toast.LENGTH_SHORT).show();
            break;
          case 3:
            Toast.makeText(MainActivity.this, "You choose the actor item", Toast.LENGTH_SHORT).show();
            break;
          case 4:
            Toast.makeText(MainActivity.this, "You choose the house item", Toast.LENGTH_SHORT).show();
            break;
        }
      }
      @Override
      public void onLongItemClick(View view, int position) { }
    }));

    prepareData();
  }
  private void prepareData() {
    ListItem item = new ListItem(" The Game :", R.drawable.ic_1);
    mList.add(item);
    item = new ListItem("The Flower :", R.drawable.ic_2);
    mList.add(item);
    item = new ListItem("The Car: ", R.drawable.ic_3);
    mList.add(item);
    item = new ListItem("The Actor :", R.drawable.ic_4);
    mList.add(item);
    item = new ListItem("The House  :", R.drawable.ic_5);
    mList.add(item);

    mAdapter.notifyDataSetChanged();
  }


}
