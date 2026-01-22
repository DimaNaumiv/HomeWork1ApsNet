using Homework_1.StylesModel;

namespace Homework_1.Styles
{
    public class Countris_Style
    {
        public string Title { get; set; }
        public string Box { get; set; }
        public string Name { get; set; }
        public string Info { get; set; }

        public Countris_Style()
        {
            Title = new Style()
            {
                color = "black"
            }.GetStyle();
            Box = new Style() 
            {
                height = 300,
                width = 600,
                justifiy_items = "center",
                alighn_items = "center",
                backgroundColor = "green",
                margin_bottom = 25,
                padding_left = 50,
                padding_right = 50,
                borderRadius = 20
            }.GetStyle();
            Name = new Style()
            {
                color = "white",
                font_wieght = "bold",
            }.GetStyle();
            Info = new Style()
            {
				color = "white",
				font_wieght = "bold",
                alighn_self = "center",
			}.GetStyle();
        }
    }
}
