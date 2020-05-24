#include <stdio.h>

// program to count the words that the user inputs 
// also to encrypt the words 

int wordCount(char *str)
{
	int i = 0;
	int count = 1;
	while (str[i] != '\0')
	{
		if (str[i] == ' ' || str[i] == '\n' || str[i] == '\t')
		{
			count++;
		}
		i++;
	}
	return count;
}

void encryption(char *str)
{
	char ch;
	int i;
	int incre = 1;
	
	for(i = 0; str[i] != '\0'; ++i)
	{
		ch = str[i];
		if(ch >= 'a' && ch <= 'z')
		{
			ch = ch + incre;
			
			if(ch > 'z')
			{
				ch = ch - 'z' + 'a' - 1;
			}	
			
			str[i] = ch;
		}
	}	
}

int main()
{
	
	
	char str[50];	
	
	do 
	{
		printf("Enter words: ");
		fgets(str, 50, stdin);
	}
	while (str[1] == '\0');


	int wrdCount = wordCount(str);
	
	printf("Number of words: %d\n", wrdCount-1);
	
	encryption(str);
	printf("Encrypted text: %s", str);

	return 0;
}
	
