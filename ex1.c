//lucky number if it just have 4 and 7
#include <stdio.h>
#include <string.h>
int main()
{
    char s[100];
    int i, count = 0;
    scanf("%s", s);
    for (i = 0; i < strlen(s); i++)
    {
        if (s[i] == '4' || s[i] == '7')
        {
            count++;
        }
    }
    if (count == 4 || count == 7)
    {
        printf("YES");
    }
    else
    {
        printf("NO");
    }
    return 0;
}