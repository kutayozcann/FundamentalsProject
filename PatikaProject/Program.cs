using System;

namespace PatikaProject{

    class Program{

        static void Main(string[] args){
            
            // Main menu loop
            bool app = false;

            while(!app){

                bool appBool = false;
                int appChoise = 0;
                
                // Show main menu until valid input is received
                while(!appBool || appChoise < 1 || appChoise > 3){

                    Console.Clear();
                    // Main menu options
                    System.Console.WriteLine("Uygulama merkezine hoş geldiniz!");   
                    System.Console.WriteLine("1 - Rastgele Sayı Bulma Oyunu");
                    System.Console.WriteLine("2 - Hesap Makinesi");
                    System.Console.WriteLine("3 - Not Ortalaması Hesaplama");
                    System.Console.Write("Kullanmak istediğiniz uygulamanın numarasını giriniz :");
                    appBool = int.TryParse(Console.ReadLine(), out appChoise);

                    // Invalid input warning
                    if(!appBool || appChoise < 1 || appChoise > 3){                         
                        System.Console.WriteLine("Lütfen geçerli bir uygulama giriniz!");   
                    }
                }

                // Redirect to the selected application
                switch(appChoise){                          
                    case 1:
                        NumberGuess();
                        break;
                    case 2:
                        Calculator();
                        break;
                    case 3:
                        GPA();
                        break;
                    default:
                        break;
                }

                // Return to menu or exit the application
                appBool = false;
                while(!appBool){
                    System.Console.WriteLine("Uyguluma menüsüne dönmek için -> 1");
                    System.Console.WriteLine("Uygulamayı kapatmak için -> 2");
                    System.Console.Write("Tercihinizi Giriniz : ");
                    appBool = int.TryParse(Console.ReadLine(), out int appRepeater);
                    if(appBool){
                        if(appRepeater == 1){
                            System.Console.WriteLine("Uygulama menüsüne dönülüyor...");
                            appBool = true;
                        }
                        else if(appRepeater == 2){
                            // Exit program                               
                            System.Console.WriteLine("Uygulama kapatılıyor...");
                            app = true;
                        }
                        else{
                            appBool = false;
                            System.Console.WriteLine("Lütfen geçerli bir seçim yapınız!");
                        }
                    }
                    else{
                        System.Console.WriteLine("Geçersiz giriş. Lütfen bir sayı giriniz.");
                    }
            }
        }
        
        // GPA Calculation
        static void GPA(){

            Console.Clear();
            System.Console.WriteLine("GPA hesaplama uygulamasına hoşgeldiniz!");

            double firstPoint = 0, 
                   secondPoint = 0,
                   thirdPoint = 0,
                   average = 0;

            int numberOfPoints = 3;
            bool validPoint = false;

            // Input for first course grade
            while(!validPoint || firstPoint < 0 || firstPoint > 100){           // Validate input range          
                System.Console.Write("Birinci ders notunu giriniz :");
                validPoint = double.TryParse(Console.ReadLine(), out firstPoint);
                if(!validPoint || firstPoint < 0 || firstPoint > 100){
                    System.Console.WriteLine("Lütfen geçerli bir not değeri giriniz giriniz.");
                }

            }
            Console.Clear();

            // Input for second course grade
            validPoint = false;
            while(!validPoint || secondPoint < 0 || secondPoint > 100){         

                System.Console.Write("İkinci ders notunu giriniz :");
                validPoint = double.TryParse(Console.ReadLine(), out secondPoint);
                if(!validPoint || secondPoint < 0 || secondPoint > 100){
                    System.Console.WriteLine("Lütfen geçerli bir not değeri giriniz giriniz.");
                }

            }
            Console.Clear();

            // Input for third course grade
            validPoint = false;
            while(!validPoint || thirdPoint < 0 || thirdPoint > 100){

                System.Console.Write("Üçüncü ders notunu giriniz :");
                validPoint = double.TryParse(Console.ReadLine(), out thirdPoint);
                if(!validPoint || thirdPoint < 0 || thirdPoint > 100){
                    System.Console.WriteLine("Lütfen geçerli bir not değeri giriniz giriniz.");
                }

            }
            Console.Clear();

            // Calculate the average grade
            average = (firstPoint+secondPoint+thirdPoint)/numberOfPoints;      
            System.Console.WriteLine("Ortalamanız : " + average);                       

            // Determine GPA based on the average
            if(average <= 100 && average >= 90){                              
                System.Console.WriteLine("GPA : AA");
            }
            else if(average <= 89.9 && average >= 85){
                System.Console.WriteLine("GPA : BA");
            }
            else if(average <= 84.9 && average >= 80){
                System.Console.WriteLine("GPA : BB");
            }
            else if(average <= 79.9 && average >= 75){
                System.Console.WriteLine("GPA : CB");
            }
            else if(average <= 74.9 && average >= 70){
                System.Console.WriteLine("GPA : CC");
            }
            else if(average <= 69.9 && average >= 65){
                System.Console.WriteLine("GPA : DC");
            }
            else if(average <= 64.9 && average >= 60){
                System.Console.WriteLine("GPA : DD");
            }
            else if(average <= 59 && average >= 55){
                System.Console.WriteLine("GPA : FD");
            }
            else{
                System.Console.WriteLine("GPA : FF");
            }
        }

        // Calculator Application
        static void Calculator(){
            Console.Clear();
            bool convertionBool = false; 
            double num1 = 0, num2 = 0;
            char symbol = ' ';
            
            // Input first number
            while(!convertionBool){                                                 
                System.Console.Write("İlk sayıyı giriniz :");                       
                convertionBool = double.TryParse(Console.ReadLine(),  out num1);
                if(!convertionBool){
                    System.Console.WriteLine("Lütfen geçerli bir sayı giriniz.");  // Show a warning for invalid input.
                }
            }

            convertionBool = false;

            // Input second number
            while(!convertionBool){
                System.Console.Write("İkinci sayıyı giriniz :");
                convertionBool = double.TryParse(Console.ReadLine(),  out num2);
                if(!convertionBool){
                    System.Console.WriteLine("Lütfen geçerli bir sayı giriniz.");
                }
            }

            // Choose operation
            Console.Clear();
            bool calcBool = false;
            while(!calcBool){
                convertionBool = false;
                while(!convertionBool){
                System.Console.Write($"{num1} ve {num2} ile yapmak istediğiniz işlemin sembolünü giriniz (+, -, /, *) : ");
                convertionBool = char.TryParse(Console.ReadLine(), out symbol);
                if(!convertionBool){
                    System.Console.WriteLine("Lütfen geçerli bir sembol giriniz."); // Show a warning for invalid input for operation.
                }
                }

                switch(symbol){
                    case '+':
                        System.Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                        System.Console.WriteLine("--------------------------------");
                        calcBool = true;
                        break;
                    case '-':
                        System.Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                        System.Console.WriteLine("--------------------------------");
                        calcBool = true;
                        break;
                    case '*':
                        System.Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                        System.Console.WriteLine("--------------------------------");
                        calcBool = true;
                        break;
                    case '/':
                        if(num2 != 0){                                                      // Check if the second number is zero.
                            System.Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                            System.Console.WriteLine("--------------------------------");
                            calcBool = true;
                        }
                        else{
                            System.Console.WriteLine("Sıfıra bölme hatası.");               // Show an error if dividing by zero.
                        }
                        break;
                    default:
                        System.Console.WriteLine("Geçersiz sembol.");
                        calcBool = false;
                        break;
                }
            }
        }
        
        // Random Number Guessing Game
        static void NumberGuess(){
            
            Console.Clear();
            System.Console.WriteLine("Sayı tahmin oyununa hoş geldiniz.");
            System.Console.WriteLine("Toplam 5 tahmin hakkınız bulunuyor.");    // Display game instructions
            System.Console.WriteLine("Bol Şanslar!");
            System.Console.Write("Başlamak için Enter tuşuna basın.");
            Console.ReadLine();
            
            Random rand = new();
            int number = rand.Next(1, 100);  // Generate a random number between 1 and 100.
            int guess = 0;
            int lives = 5;
            int tempUpper = 100;
            int tempLower = 0;

            while (lives > 0 && guess != number){
                
                System.Console.WriteLine("--------------------------------------------------");
                System.Console.Write($"Lütfen {tempLower} ile {tempUpper} bir sayı girin: ");
                

                if(int.TryParse(Console.ReadLine(), out guess) && guess < tempUpper && guess > tempLower){    // Check if the guess is valid and within the allowed range.

                     if (guess < number){
                        System.Console.WriteLine("--------------------------------------------------");
                        System.Console.WriteLine("Sayı daha yüksek.");  // Guide the player
                        tempLower = Math.Max(tempLower, guess);
                    }
                    else if (guess > number){
                        System.Console.WriteLine("--------------------------------------------------");
                        System.Console.WriteLine("Sayı daha düşük.");   // Guide the player
                        tempUpper = Math.Min(tempUpper, guess);
                    }
                    else{
                        System.Console.WriteLine("--------------------------------------------------");
                        System.Console.WriteLine("Tebrikler! Sayıyı buldunuz.");    // Correct guess
                        return;
                    }
                    lives--;
                    System.Console.WriteLine($"Kalan tahmin haklarınız: {lives}");  // Display remaining lives of player
                    
                    
                }
                else{
                    System.Console.WriteLine("Lütfen belirtilen aralıkta ve geçerli bir sayı girin.");
                }

               
                }   
                Console.Clear();
                System.Console.WriteLine($"Tahmin haklarınız bitti. Sayı: {number}");   // Game over message
            }
        }
    }
}
