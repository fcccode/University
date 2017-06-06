package rpanel.a2_lab.com.lab_5;

import android.support.v7.widget.RecyclerView;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;
import android.widget.TextView;
import java.util.List;

public class Adapter extends RecyclerView.Adapter<Adapter.MyViewHolder> {

  private List<ListItem> itemList;

  public Adapter(List<ListItem> itemList) {
    this.itemList = itemList;
  }

  public class MyViewHolder extends RecyclerView.ViewHolder {
    public TextView title;
    public ImageView img;

    public MyViewHolder(View view) {
      super(view);
      title = (TextView) view.findViewById(R.id.title);
      img = (ImageView) view.findViewById(R.id.imageView);
    }
  }

  @Override
  public MyViewHolder onCreateViewHolder(ViewGroup parent, int viewType) {
    View itemView = LayoutInflater.from(parent.getContext())
        .inflate(R.layout.list_item, parent, false);

    return new MyViewHolder(itemView);
  }

  @Override
  public void onBindViewHolder(MyViewHolder holder, int position) {
    ListItem item = itemList.get(position);
    holder.title.setText(item.getTitle());
    holder.img.setImageResource(item.getImageId());
  }

  @Override
  public int getItemCount() {
    return itemList.size();
  }

}
