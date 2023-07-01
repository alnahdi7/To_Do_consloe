
List<string> list_to_do = new List<string>();
bool runnig = true;

while (runnig == true)
{
    Console.WriteLine("plaess chaees Opration you want:- ");
    Console.WriteLine("preass number 1 to Add Task ");
    Console.WriteLine("preass number 2 to Viwe Task ");
    Console.WriteLine("preass number 3 to Deleat Task ");
    Console.WriteLine("preass number 4 to Remov All Tasks ");
    Console.WriteLine("preass number 5 to Exsit ");
    Console.WriteLine("------------------------------------------- ");
    string opration = Console.ReadLine();
    switch (opration)
    {
        case "1":
            Console.Write("Plaess Enter The  Task : ");
            string new_task = Console.ReadLine();
            list_to_do.Add(new_task);
            Console.WriteLine("Task is added Successfuly ");

            break;
        case "2":
            if (list_to_do.Count > 0)
            {
                Console.WriteLine("Tasks :- ");
                for (int i = 0; i < list_to_do.Count; i++)
                {

                    Console.WriteLine($"NO {i + 1} : " + list_to_do[i] + "");

                }
            }
            else Console.WriteLine("No tasks For Viwee ");
            break;
        case "3":

            if (list_to_do.Count > 0)
            {
                Console.WriteLine("Enter Number The Task For Delet ");

                int id_remove = int.Parse(Console.ReadLine());
                if (id_remove > 0 && id_remove < list_to_do.Count + 1)
                {
                    for (int i = 0; i < list_to_do.Count; i++)
                    {
                        if (id_remove == i + 1)
                        {
                            list_to_do.Remove(list_to_do[id_remove - 1]);
                        }

                    }
                    Console.WriteLine("Successfuly Deleted Task ");
                }
                else
                    Console.WriteLine("This is number not exist ");
            }
            else Console.WriteLine("No tasks For Deleted ");
            break;
        case "4":
            if (list_to_do.Count > 0)
            {
                list_to_do.Clear();
                Console.WriteLine("Successfuly Deleted All Tasks ");
            }
            else Console.WriteLine("No tasks For Removed ");

            break;

        case "5":
            Console.WriteLine("Tanks ford uosing our To DO");
            runnig = false;
            break;

        default:
            Console.WriteLine("Invalid Opration tray agin ");
            break;

    }
}


