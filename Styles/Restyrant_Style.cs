using Homework_1.StylesModel;

namespace Homework_1.Styles
{
    public class Restyrant_Style
    {
        public string MainInfoBox { get; set; }
        public string HelpInfoBox { get; set; }

        public string Name {  get; set; }
        public string Adress {  get; set; }
        public string Number { get; set; }
        public string Email { get; set; }

        public Restyrant_Style()
        {
            MainInfoBox = new Style()
            {
                height = 180,
                width = 600,
                alighn_items = "center",
                justifiy_items = "center",
                backgroundColor = "blue",
                borderRadius = 20
            }.GetStyle();
            HelpInfoBox = new Style()
            {
                height = 180,
                width = 600,
                alighn_items = "center",
                justifiy_items = "center",
                backgroundColor = "yellow",
                borderRadius = 20
            }.GetStyle();

            Name = new Style()
            {
                color = "white",
                font_wieght = "bold",
                margin_bottom = 5
            }.GetStyle();
            Adress = new Style()
            {
                color = "white",
                font_wieght = "bold",
            }.GetStyle();
            Email = new Style()
            {
                font_wieght = "bold",
                margin_bottom = 5
            }.GetStyle();
            Number = new Style()
            {
                font_wieght = "bold",
            }.GetStyle();
        }
    }
}
