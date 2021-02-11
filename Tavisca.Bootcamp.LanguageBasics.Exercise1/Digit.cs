namespace Tavisca.Bootcamp.LanguageBasics.Exercise1
{
    public class Digit
    {
        public string Value { get; set; }
        public bool IsValid(){
            return int.TryParse(Value, out int val);
        }
        public bool IsZero(){
            return Value.Equals("0");
        }       
    }

}