#include <iostream>
#include <cstring>

#define MAX 51
#define minGrade 4

int strToInt(char* input)
{
    int digit;
    int num = 0;
    int i = 0;

    while(input[i] != '\0')
    {
        digit = input[i] - '0';
        num = num * 10 + digit;
        
        i++;
    }

    return num;
}

int gradeCount = 0;
int sum = 0;
float getAverage(char* input)
{
    int grade = 0;

    char* num = strtok(input, " ");
    while (num != NULL)
    {
        grade = strToInt(num);
        sum += grade;
        gradeCount++;

        num = strtok(NULL, " ");
    }

    return (float) sum / gradeCount;
}

void getResults(float targetAverage, int grade, float newSum, int newGradeCount)
{
    float average = (float) newSum / newGradeCount;
    if (average >= targetAverage)
    {
        std::cout << grade - 1 << ' ';
        return;
    }
    else
    {
        if (grade <= 10)
        {
            getResults(targetAverage, grade + 1, sum + grade, gradeCount + 1);
        }
        else
        {
            std::cout << 10 << ' ';
            sum += 10;
            gradeCount++;
            getResults(targetAverage, minGrade, sum, gradeCount);
        }
    }
}

int main()
{
    char input[MAX];
    std::cout << "Input your grades: ";
    std::cin.getline(input, MAX);

    float average = getAverage(input);
    float targetAverage;
    std::cout<<"Input your target average: ";
    std::cin >> targetAverage;

    std::cout << "The grades you need: ";
    getResults(targetAverage, minGrade, sum, gradeCount);

    return 0;
}