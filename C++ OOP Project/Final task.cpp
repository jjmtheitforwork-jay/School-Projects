#include<iostream>
#include<fstream>
#include<cstring>
using namespace std;
class baseMember //Parent class
{
	public: //access specifier
		char mb_id[10];
	virtual void addMember(){} // pure virtual function
	virtual void modifyMember(){}
	virtual void showMember(){}
};
class Member:public baseMember //child class (inheritance)
{
	private:
		char mb_name[30];
		char mb_type[20];
		int points;
	public:
		void addMember()				//user define function for write operation
		{
			cout<<"Enter the member name :";cin>>mb_name;
			cout<<"Enter the member ID :";cin>>mb_id;
			cout<<"Enter the member type :";cin>>mb_type;
			if(strcmp(mb_type,"Gold")==0||strcmp(mb_type,"Silver")==0) //m_type == Gold || m_type == Silver
			{
				cout<<"Enter the member points :";cin>>points;
			}
			else
			{
				points = 0;
			}
		}
		void showMember()				//user define function for read operation
		{
			cout<<mb_name<<" "<<mb_id<<" "<<mb_type<<" "<<points<<endl;
		}	
		void modifyMember()				//user define function to modify
		{
			char name[30];
			char type[20];
			int npoints;
			cout<<"Enter new data to modify.\n";
			cout<<"Enter the new member name :";cin>>name;
			cout<<"Enter the new member type :";cin>>type;
			if(strcmp(type,"Gold")==0||strcmp(type,"Silver")==0) 
			{
				cout<<"Enter new member points to modify :";cin>>npoints;
			}
			else
			{
				npoints = 0;
			}
			
			strcpy(mb_name,name);		//strcpy = string copy
			strcpy(mb_type,type);
			points = npoints;
		}	
};
int main()
{
	Member M1;					//Base class object
	baseMember* ptr =&M1; 		//Base class pointer for polymorphism
	char ans;
	int choice;
	do
	{
		cout<<"\n----------MAIN MENU----------"<<endl;
		cout<<"\nChoice 1: Add new member to the file\n";
		cout<<"Choice 2: Modify existing member to the file\n";
		cout<<"Choice 3: Display members details from the file\n";
		cout<<"Choice 4: Exit the process\n";
		cout<<"Choose an option (1-4) :";
		cin>>choice;
		if(choice == 1)				//add member: write operation
		{
			ofstream outfile("MEMBER.txt",ios::out|ios::app|ios::binary); //input output system
			if(outfile.is_open())
			{
				do
				{
					ptr ->addMember();		//polymorphic call
					outfile.write((char*)&M1,sizeof(M1));
					cout<<"New member is added to file\n";
					cout<<"\nWould you like to add more member?(y/n) :";
					cin>>ans;	
				}while(ans == 'y'||ans == 'Y');
				outfile.close();
			}
			else
			{
				cout<<"Unable to open file to write.\n";
			}
		}
		else if (choice == 2)				//modify member : write + read 
		{
			char search_id[10];
			bool found = false;
			cout<<"\nEnter the member ID that you want to modify :";
			cin>>search_id;
			fstream file("MEMBER.txt",ios::in|ios::out|ios::binary);	//input output system
			if(file.is_open())
			{
				while(file.read((char*)&M1,sizeof(M1)))
				{
					if(strcmp(ptr->mb_id,search_id)==0)
					{
						ptr->showMember();		//polymorphic call
						ptr->modifyMember();	//polymorphic call
						file.seekp(file.tellg()-std::streamoff((sizeof(M1))),ios::beg);
						file.write((char*)&M1,sizeof(M1));
						found = true;
						cout<<"Member is successfully modified to the file.\n";
						break;
					}
				}
				if(found == false)
				{
					cout<<"Sorry!! Member ID is not found in the file\n";
				}
			}
			else
			{
				cout<<"Unable to open file to modify.\n"<<endl;
			}
		}
		else if (choice == 3)			//show member : read operation
		{
			ifstream infile("MEMBER.txt",ios::in|ios::out|ios::binary);	//input output system
			if(infile.is_open())
			{
				while(infile.read((char*)&M1,sizeof(M1)))
				{
					ptr->showMember();	//polymorphic call
				}
				infile.close();
			}
			else
			{
				cout<<"Unable to open file to read.\n";
			}
		}
		else
		{
			cout<<"Process is ended.";
		}
	}while(choice == 1||choice == 2||choice == 3);
	return 0;
}
