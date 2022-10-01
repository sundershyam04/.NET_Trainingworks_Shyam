using System;

public class Student
{
	private int _studid;

	public int StudentId
	{
		get { return _studid; }
		set { _studid = value; }
	}

	private string _studname;

	public string StudName
	{
		get { return _studname; }
		set 
		
		{
			if (value.Length <= 40){
				_studname = value;
			}
			else
			{
				throw new Exception("Student name can be maximum of 40characters only");
			}
		}
	}

	private int _courseid;

	public int CourseId
	{
		get { return _courseid; }
		set { _courseid = value; }
	}



}
