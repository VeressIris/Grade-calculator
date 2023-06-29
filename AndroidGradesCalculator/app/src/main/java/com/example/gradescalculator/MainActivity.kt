package com.example.gradescalculator

import android.os.Bundle
import android.widget.Button
import android.widget.TextView
import android.widget.Toast
import androidx.appcompat.app.AppCompatActivity
import java.util.StringTokenizer
import java.lang.Math.round

class MainActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        val currentGradesText = findViewById<TextView>(R.id.currentGradesText)
        val targetAverageText = findViewById<TextView>(R.id.targetAverageText)
        val neededGradesText = findViewById<TextView>(R.id.neededGradesText)
        val calculateButton = findViewById<Button>(R.id.calculateButton)

        calculateButton.setOnClickListener {
            //check validity of input first:
            if (!validInput(currentGradesText.text.toString())) {
                Toast.makeText(this, "Input valid grades!", Toast.LENGTH_LONG).show()
            }
            else if (targetAverageText.text.isEmpty()){
                Toast.makeText(this, "Input a target average!", Toast.LENGTH_LONG).show()
            }
            else { //for valid input:
                getAverageData(currentGradesText.text.toString())

                var targetAverage = targetAverageText.text.toString().toFloat()
                //if target average is already = average
                if (targetAverage.toInt() == Math.round(sum / gradeCount.toFloat())){
                    neededGradesText.text = "Your average is already ${targetAverage.toInt()}."
                }
                else {
                    targetAverage -= 0.5f //-0.5 to get the minimum average needed

                    neededGrades.clear() //clear grades array to make sure you can calculate from scratch again

                    getGrades(targetAverage, minGrade, sum, gradeCount)

                    outputGrades(neededGradesText)
                }
            }
        }
    }

    fun validInput(input:String):Boolean{
        for (i in input.indices){
            if (!input[i].isDigit() && input[i] != ' '){
                return false
            }
        }

        return true
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

    val maxGradeAmount = 6
    fun outputGrades(neededGradesText: TextView): Void?{
        if (neededGrades.size > maxGradeAmount){
            neededGradesText.text = "You would need ${neededGrades.size} grades. You cannot get that many this year.\nGood luck next time!"
        }
        else{
            var tempStr = ""
            for (grade in neededGrades) {
                tempStr += grade.toString() + " "
            }
            neededGradesText.text = tempStr
        }

        return null
    }
}