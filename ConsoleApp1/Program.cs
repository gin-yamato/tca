//BMI計算プログラム

using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            float height = GetInputAndparse("身長を入力してください。(m)");
            float weight = GetInputAndparse("体重を入力してください(kg)");
            float bmi = GetBMI(height, weight);

            Console.WriteLine("BMIは" + bmi + " です");
        }

        static float GetInputAndparse(string message)
        {
            float parsed = 0f;
            bool parseSuccess = false;
            while (!parseSuccess)
            {
                Console.WriteLine(message);
                string input = Console.ReadLine();
                parseSuccess = float.TryParse(input, out parsed);
                if (!parseSuccess)
                    Console.WriteLine("数値を入力してください");
            }
            return parsed;
        }
        static float GetBMI(float height, float weight)
        {
            return weight / (height * height);
        }
    }
}
