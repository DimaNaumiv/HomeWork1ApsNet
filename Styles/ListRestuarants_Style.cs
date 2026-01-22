using Homework_1.StylesModel;

namespace Homework_1.Styles
{
    public class ListRestuarants_Style
    {
        public string Title { get; set; }
        public string Boxes { get; set; }
        public string Box {  get; set; }
        public string MainInfo { get; set; }
        public string HelpInfo { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Addres { get; set; }

        public ListRestuarants_Style()
        {
            Title = new Style()
            {

            }.GetStyle();
			Name = new Style()
			{
				color = "white",
				font_wieght = "bold",
				margin_bottom = 5
			}.GetStyle();
			Email = new Style()
			{
				color = "white",
				font_wieght = "bold",
				margin_bottom = 5
			}.GetStyle();
			Phone = new Style()
			{
				color = "white",
				font_wieght = "bold",
				margin_bottom = 5
			}.GetStyle();
			Addres = new Style()
			{
				color = "white",
				font_wieght = "bold",
				margin_bottom = 5
			}.GetStyle();

			Box = new Style()
			{
				margin_bottom = 30
			}.GetStyle();
			Boxes = new Style()
			{
				width = 500,
				alighn_self = "center",
				alighn_items = "center"
			}.GetStyle();

			MainInfo = new Style()
			{
				width = 400,
				height = 150,
				backgroundColor = "green",
				alighn_items = "center",
				justifiy_items = "center",
				borderRadius = 10
			}.GetStyle();
			HelpInfo = new Style()
			{
				width = 400,
				height = 150,
				backgroundColor = "purple",
				alighn_items = "center",
				justifiy_items = "center",
				borderRadius = 10
			}.GetStyle();
		}
    }
}
