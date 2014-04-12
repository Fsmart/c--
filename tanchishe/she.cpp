#include<iostream>
#include<time>
#include<stdlib>
#include<conio>
#define N 21
void gotoxy(int x,int y)
{
	COORD pos;
	pos.X=2*x;
	pos.Y=y;
	setconsoleCursorPosition(GetStadHandle(STD_OUTPUT_HANDLE),pos);
}
void color( int a)
{
	SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE),a);
}
void init(int apple)
{
	int i,j;
	int wall[N+2][N+2] = {{0}};
	for (i = 1;i<=N;j++)
	{
		for(j=1;j<=N;j++)
			wall[i][j] = 1;
	}
	color(11);
	for(i =0;i<N+2;i++)
	{
		for(j=0;j<N+2;j++)
		{
			if(wall[i][j])
				cout<<"io";
				else cout <<"io";
		}
		cout <<endl;
	}
	gotoxy(N+3,1);
	color(20);
	cout <<"w a s d"<<endl;
	gotoxy(N+3,2);
	color(20);
	cout<<""<<endl;
	goto
