#include <stdio.h>
#include <stdlib.h>
int main()
{
	//#define IN 1
	//#define OUT 0

	//char c, file_name[25];
	//int nl, nw, nc, state;
	//FILE *fp;

	//printf("Enter name of a file you wish to see\n");
	//gets(file_name);

	//fp = fopen(file_name, "r"); // read mode

	//if (fp == NULL)
	//{
	//	perror("Error while opening the file.\n");
	//	exit(EXIT_FAILURE);
	//}

	//state = OUT;
	//nl = nw = nc = 0;

	//while ((c = fgetc(fp)) !=EOF) {
	//	++nc;
	//	if (c == '\n')
	//		++nl;
	//	if (c == ' ' || c == '\n' || c == '\t')
	//		state = OUT;
	//	else if (state == OUT)
	//	{
	//		state = IN;
	//		++nw;
	//	}
	//}
	//printf("%d %d %d\n", nl, nw, nc);

	//fclose(fp);
	//return 0;

	int power(int, int);

	int m, n;
	printf("hi, please enter the freaking numbers: ");
	scanf("%d", m);
	scanf("%d", n);

	int result = Power(m, n);

	prtinf("result is %d" + result);

	return 0;
}

int Power(int m, int n) {
	int p = m;

	if (n == 0 || n == 1)
	{
		if (m == 0)
			return 0;
		else
		{
			return m;
		}
	}

	else
	{
		for (int i = 1; i < n; i++)
		{
			p = p * m;
		}
		return p;
	}
}