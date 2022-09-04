[# **Tic Tac Toe**](https://www.youtube.com/watch?v=5SdW0_wTX5c)
---

<br>

## Историја
---
Tic-tac-toe, Noughts and Crosss, или Xs and Os е игра со хартија и молив за двајца играчи кои наизменично ги обележуваат празнините места во мрежа од 3х3 со X или O. Играчот кој прв ќе успее да постави три од нивните знаци во хоризонтален, вертикален или дијагонален ред е победник. Играта може да заврши и нерешно, претпоставувајќи најдобра игра од двајцата играчи.

<br>

## Како се игра?
---
Веројатно веќе знаете како да играте Tic-Tac-Toe. Тоа е навистина едноставна игра, нели? Така мислат повеќето од нас. Но, ако навистина го вклучиме мозокот, ќе откриеме дека Tic-Tac-Toe не е толку едноставен како што мислиме!
Tic-Tac-Toe (заедно со многу други игри) вклучува предвидувања и обид да се открие што може следно да направи спротивниот играч.
Правилата се едноставни.Треба да изградите линија (хоризонтална, вертикална, дијагонална) од три знаци(три Х или три О), додека го спречувате вашиот противник да го направи 
истото. 

<br>

## Упатство за користење
---
![alt text](https://github.com/MSpasovska21/TicTacToe/blob/master/images/home.png "Почетна страна")

Почетната страна се состои од 3 копчиња и дел за авторски права.
- Копчето **Play** ја започнува играта.
- Копчето **How to play** отвара форма со испишани правила за играње на играта.
- Копчето **Exit** ја исклучува апликацијата.
- Лабелата **© 2020 FCSE** ги испишува авторските права.

![alt text](https://github.com/MSpasovska21/TicTacToe/blob/master/images/howToPlay.png "Правила на играта")
![alt text](https://github.com/MSpasovska21/TicTacToe/blob/master/images/copyright.png "Авторски права")

Формата **Game** се состои од 3х3 мрежа, имињата на двата играчи со бројот на победени рунди до нив и 3 копчиња. Можни исходи од играта се „Играчот Х победи“, „Играчот О победи“ и „Нерешено“. 
По завршувањето на играта може да изберете Restart и да играте уште една рунда или пак New Game и да започнете одново. Доколку се одлучите за уште една игра резултатите се рестартираат и новата игра започнува. На Exit апликацијата се гаси.

![alt text](https://github.com/MSpasovska21/TicTacToe/blob/master/images/game.png "Игра")

<br>

## Имплементација 
---
Функцијата ```score()``` во ```Game.cs```
```
void score()
        {
            if(button1.Text=="X" && button2.Text == "X" && button3.Text == "X")
            {
                button1.BackColor = Color.PowderBlue;
                button2.BackColor = Color.PowderBlue;
                button3.BackColor = Color.PowderBlue;

                MessageBox.Show("The winner is Player X", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusone+1);
                Enable_False();

            }
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                button1.BackColor = Color.Pink;
                button4.BackColor = Color.Pink;
                button7.BackColor = Color.Pink;

                MessageBox.Show("The winner is Player X", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusone+1);
                Enable_False();

            }
            .
            .
            .
        }
```
Знаеме дека целта во играта е да има поврзано 3 знаци хоризонтално, вертикално или дијагонално.
Оваа функција токму тоа го проверува и враќа порака ако одреден играч е во победничка позиција.
Функцијата се извршува при секој потег на било кој играч. Па доколку има линија од 3 исти знаци, линијата ќе се избои со соодветна боја, ќе се испише порака кој играч победил и ќе се зголеми резултатот до соодветниот играч. Проверката се прави за секој играч и секоја можна линија (хоризонтална, вертикална, дијагонална).



---
Апликацијата Tic Tac Toe е изработена од Моника Спасовска под менторство на проф. д-р Дејан Ѓорѓевиќ и ас. Стефан Андонов. Проектот е дел од предметот [Визуелно програмирање](https://www.finki.ukim.mk/mk/subject/%D0%B2%D0%B8%D0%B7%D1%83%D0%B5%D0%BB%D0%BD%D0%BE-%D0%BF%D1%80%D0%BE%D0%B3%D1%80%D0%B0%D0%BC%D0%B8%D1%80%D0%B0%D1%9A%D0%B5-0) на [Факултетот за Информатички Науки и Компјутерско Инженерство](https://www.finki.ukim.mk/) во академска година 2021/2022. 
