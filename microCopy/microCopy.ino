#define TAILLE_TABLEAU (4)

int  i = 0;
char tab[TAILLE_TABLEAU];

void setup()
{
  Serial.begin(9600);
}

void loop()
{
  if(Serial.available() > 0)
  {
    while(Serial.available())
    {
      tab[i++] = Serial.read();
    }
    
    if(tab[0] == 0x02 && tab[1] == 0x0C && tab[2] == 0x00 && tab[3] == 0x00)
    {
      Serial.write("OK\r\n");
      Serial.write("Your data is : ");
      Serial.write(0x74);
      Serial.write(0x65);
      Serial.write(0x6D);
      Serial.write(0x70);
      Serial.write(0x3A);
      Serial.write(0x32);
      Serial.write(0x1F);
      Serial.write(0x43);
      Serial.write("\r\n");
      
      for(int count = 0;count<TAILLE_TABLEAU;count++)
      {
        tab[count] = ' ';
      }
    }
    else if(tab[0] != 0x02 || tab[1] != 0x0C || tab[2] != 0x00 || tab[3] != 0x00)
    {
      Serial.write("BAD COMMAND\r\n");
      
      for(int count = 0;count<TAILLE_TABLEAU;count++)
      {
        tab[count] = ' ';
      }
    }
  }
  
  i = 0;
  delay(1000);
}

