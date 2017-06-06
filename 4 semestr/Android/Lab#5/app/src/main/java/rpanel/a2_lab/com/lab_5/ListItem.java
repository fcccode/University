package rpanel.a2_lab.com.lab_5;

public class ListItem {
  private String title;
  private int img;

  public ListItem(String title, int image) {
    this.title = title;
    this.img = image;
  }

  public String getTitle() {
    return title;
  }

  public int getImageId() {
    return img;
  }
}