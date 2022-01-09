// 4. Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. 
//На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
//Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. 
//С помощью цикла do while ограничить ввод пароля тремя попытками.


string login = "root";
string password = "GeekBrains";
string loginUser, passwordUser;

int tries = 3;


do
{
    Console.WriteLine ("Введи логин и пароль");
    loginUser = Console.ReadLine();
    passwordUser = Console.ReadLine();
    tries--;

if (login == loginUser && password == passwordUser)

     Console.WriteLine ("Логин и пароль введен верно!");

else Console.WriteLine ("Логин и пароль введен неверно!");

} while (login != loginUser && password != passwordUser && tries > 0);

   
       

