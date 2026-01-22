using System.Text;

namespace Homework_1.StylesModel
{
    public class Style
    {
        public int? height { get; set; }
        public int? width { get; set; }
        public string? backgroundColor { get; set; }
        public int? borderRadius { get; set; }
        public string? justifiy_items { get; set; }
        public string? alighn_items { get; set; }
        public string? justifiy_self { get; set; }
        public string? alighn_self { get; set; }
        public int? border_width { get; set; }
        public string? border_color { get; set; }
        public string? color {  get; set; }
        public int? font_size { get; set; }
        public string? font_wieght { get; set; }

        public int? margin_top { get; set; }
        public int? margin_bottom { get; set; }
        public int? margin_left { get; set; }
        public int? margin_right { get; set; }

        public int? padding_top { get; set; }
        public int? padding_bottom { get; set; }
        public int? padding_left { get; set; }
        public int? padding_right { get; set; }

        public Style()
        {
            height = null;
            width = null;
            backgroundColor = null;
            borderRadius = null;

            justifiy_items = null;
            alighn_items = null;
            justifiy_self = null;
            alighn_self = null;

            border_width = null;
            border_color = null;
            borderRadius =null;

            color = null;
            font_size = null;
            font_wieght = null;

            margin_top = null;
            margin_bottom = null;
            margin_left = null;
            margin_right = null;

            padding_top = null;
            padding_bottom = null;
            padding_left = null;
            padding_right = null;
        }

        public string GetStyle()
        {
            StringBuilder sb = new StringBuilder();
            if (height != null)
            {
                sb.Append($"height:{height}px;");
            }
            if(width != null)
            {
                sb.Append($"width:{width}px;");
            }
            if(backgroundColor != null)
            {
                sb.Append($"background-color:{backgroundColor};");
            }
            if (borderRadius != null)
            {
                sb.Append($"border-radius:{borderRadius}px;");
            }
            if (borderRadius != null)
            {
                sb.Append($"border-radius:{borderRadius}px;");
            }
            if(border_width != null)
            {
                sb.Append($"border-width:{border_width}px;");      
            }
            if(border_color != null)
            {
                sb.Append($"border-color:{border_color};");
            }
            if(justifiy_items != null)
            {
                sb.Append($"justify-items:{justifiy_items};");
            }
            if(alighn_items!= null)
            {
                sb.Append($"align-content:{alighn_items};");
            }
            if( justifiy_self != null)
            {
                sb.Append($"justify-self:{justifiy_self};");
            }
            if (alighn_self != null)
            {
                sb.Append($"align-self:{alighn_self};");
            }
            if(color != null)
            {
                sb.Append($"color:{color};");
            }
            if(font_size != null)
            {
                sb.Append($"font-size:{font_size}px;");
            }
            if(font_wieght != null)
            {
                sb.Append($"font-weight:{font_wieght};");
            }

            if(margin_top != null)
            {
                sb.Append($"margin-top:{margin_top}px;");
            }
            if (margin_bottom != null)
            {
                sb.Append($"margin-bottom: {margin_bottom}px;");
            }
            if (margin_left != null)
            {
                sb.Append($"margin-left: {margin_left}px;");
            }
            if (margin_right != null)
            {
                sb.Append($"margin-right: {margin_right}px;");
            }

            if (padding_top != null)
            {
                sb.Append($"padding-top: {padding_top}px;");
            }
            if (padding_bottom != null)
            {
                sb.Append($"padding-bottom:{padding_bottom}px;");
            }
            if (padding_left != null)
            {
                sb.Append($"padding-left:{padding_left}px;");
            }
            if (padding_right != null)
            {
                sb.Append($"padding-right:{padding_right}px;");
            }
            return sb.ToString();
        }
    }
}
