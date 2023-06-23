package com.example.gradescalculator

import android.os.Bundle
import android.widget.Button
import android.widget.TextView
import androidx.appcompat.app.AppCompatActivity
import java.util.StringTokenizer

class MainActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        val currentGradesText = findViewById<TextView>(R.id.currentGradesText)
        val targetAverageText = findViewById<TextView>(R.id.targetAverageText)
        val neededGradesText = findViewById<TextView>(R.id.neededGradesText)
        val calculateButton = findViewById<Button>(R.id.calculateButton)

        calculateButton.setOnClickListener {
            getAverageData(currentGradesText.text.toString())

            val targetAverage = targetAverageText.text.toString().toFloat()
            neededGrades.clear()
            getGrades(targetAverage, minGrade, sum, gradeCount)

            var tempStr = ""
            for (grade in neededGrades) {
                tempStr += grade.toString() + " "
            }
            neededGradesText.text = tempStr
        }
    }

    var sum:Int = 0
    var gradeCount: Int = 0
    fun getAverageData(grades: String){
        gradeCount = 0
        sum = 0
        var grade: Int?

        val st = StringTokenizer(grades)
        while(st.hasMoreTokens()){
            grade = st.nextToken().toInt()

            sum += grade
            gradeCount++
        }
    }

    val minGrade = 4
    var neededGrades = mutableListOf<Int>()
    fun getGrades(targetAverage: Float, grade: Int, newSum: Int, newGradeCount: Int): Void?{
        val average:Float = newSum / newGradeCount.toFloat()
        if (average >= targetAverage) {
            neededGrades.add(grade - 1)
            return null
        }
        else {
            if (grade <= 10) {
                getGrades(targetAverage, grade + 1, sum + grade, gradeCount + 1)
            }
            else {
                neededGrades.add(10)
                sum += 10
                gradeCount++
                getGrades(targetAverage, minGrade, sum, gradeCount)
            }
        }

        return null
    }

}