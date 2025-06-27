using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Vampire_Epidemic
{
    public partial class Form1 : Form
    {
        private string name, pattern_answer, bat;
        private int garlics_count = 5, t_num = 0;


        public Form1()
        {
            InitializeComponent();
            veSlide1.Visible = false;
            userName.Visible = false;
            enterName.Visible = false;
            submitBtn.Visible = false;
            veSlide2.Visible = false;
            n1.Visible = false;
            quit.Visible = false;
            counter.Visible = false;
            veText1.Visible = false;
            stayAtHomeSlide1.Visible = false;
            sahText1.Visible = false;
            startBtn.Visible = false;
            stayAtHomeSlide2.Visible = false;
            sahText2.Visible = false;
            answer1.Visible = false;
            sahText3.Visible = false;
            stayAtHomeSlide3.Visible = false;
            garlicIncText.Visible = false;
            bedroomSlide1.Visible = false;
            answer2.Visible = false;
            submit1.Visible = false;
            garlicDecText.Visible = false;
            sahText4.Visible = false;
            answer3.Visible = false;
            sahText5.Visible = false;
            sahText6.Visible = false;
            stayAtHomeSlide4.Visible = false;
            submit2.Visible = false;
            submit3.Visible = false;
            stayAtHomeSlide5.Visible = false;
            answer4.Visible = false;
            sahText7.Visible = false;
            sahText8.Visible = false;
            submit4.Visible = false;
            answer5.Visible = false;
            sahText9.Visible = false;
            sahText10.Visible = false;
            stayAtHomeSlide6.Visible = false;
            submit5.Visible = false;
            sahText11.Visible = false;
            sahText12.Visible = false;
            sahText13.Visible = false;
            sahText14.Visible = false;
            answer6.Visible = false;
            answer7.Visible = false;
            stayAtHomeSlide7.Visible = false;
            stayAtHomeSlide8.Visible = false;
            submit7.Visible = false;
            stayAtHomeSlide9.Visible = false;
            submit6.Visible = false;
            answer8.Visible = false;
            sahText15.Visible = false;
            sahText16.Visible = false;
            stayAtHomeSlide10.Visible = false;
            submit8.Visible = false;
            stayAtHomeSlide11.Visible = false;
            submit9.Visible = false;
            hideBtn.Visible = false;
            dontHideBtn.Visible = false;
            sahText17.Visible = false;
            survivedText.Visible = false;
            survived.Visible = false;
            attacked.Visible = false;
            restart.Visible = false;
        }

        private void attack()
        {
            if(garlics_count < 2)
            {
                reset();
                veIntro.Visible = false;    
                playBtn.Visible = false;
                attacked.Visible = true;
                survivedText.Visible = true;
                restart.Visible = true;

                survivedText.Text = "Attacked by the Vampires!! \n you did't survive the day";

                survivedText.Parent = attacked;
                restart.Parent = attacked;
            }
        }

        private void playBtn_Click(object sender, EventArgs e)
        {
            veIntro.Visible = false;
            veSlide1.Visible = true;
            enterName.Visible = true;
            userName.Visible = true;
            submitBtn.Visible = true;

            userName.Parent = veSlide1;
            enterName.Parent = veSlide1;
            submitBtn.Parent = veSlide1;

            name = "";
            enterName.Text = "Enter your name: ";
            userName.Text = "";
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(userName.Text))
            {
                MessageBox.Show("Name is required.");
            }
            else
            {
                veSlide1.Visible = false;
                enterName.Visible = false;
                userName.Visible = false;
                submitBtn.Visible = false;
                veSlide2.Visible = true;
                quit.Visible = true;
                counter.Visible = true;
                n1.Visible = true;
                veText1.Visible = true;

                veText1.Parent = veSlide2;
                n1.Parent = veSlide2;
                quit.Parent = veSlide2; 
                counter.Parent = veSlide2;

                veText1.Text = "The sun is shining, but something feels off. The sky has a strange, hazy glow, and the city's usual buzz\nis replaced by silence. Suddenly, a loud alarm blares through the streets.A voice from the speakers echoes: \n\n Alert! Today is Vampire Attack Day! All citizens are advised to stay indoors for their safety.\n \n Shops are closed, roads are empty, and the air feels tense. " + name + ", you stand at your window, \ngripping your bag. You have 5 garlics — your only defense against the vampires. They may not fear the sun \nanymore, and shadows are lurking where they shouldn't be.But today isn't just any day for you. It's the\ndeadline for your most important university assignment. Missing it could cost you dearly, but stepping \noutside means facing the unknown dangers of Vampire Attack Day. \nThe choice is yours, " + name + ". Time is ticking. What will you do?";
                counter.Text = "🧄 Garlics = " + garlics_count;
                name = userName.Text;
            }
        }

        private void intro()
        {
            sahText1.Visible = true;

            counter.Text = "🧄 Garlics = " + garlics_count;
            sahText1.Text = name + ", you have 5 garlics to start with. Each correct move you make will earn you 1 extra garlic, \nbut be careful! Every wrong move will cost you 1 garlic. To survive the vampire attack, you must have \nat least 2 garlics. If your garlic count drops below 2, you will be too weak to fight the vampire and the\ngame will be over. So, think wisely before making your move!\nAre you ready to start?";
        }

        private void n1_Click(object sender, EventArgs e)
        {
            veSlide2.Visible = false;
            n1.Visible= false;
            veText1.Visible = false;
            stayAtHomeSlide1.Visible = true;
            startBtn.Visible = true;

            intro();

            startBtn.Parent = stayAtHomeSlide1;
            sahText1.Parent = stayAtHomeSlide1;
            counter.Parent = stayAtHomeSlide1;
            quit.Parent = stayAtHomeSlide1;
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            //task 01
            stayAtHomeSlide1.Visible = false;
            startBtn.Visible = false;
            sahText1.Visible = false;
            stayAtHomeSlide2.Visible = true;
            sahText2.Visible = true;
            answer1.Visible = true;
            submit1.Visible = true;

            t_num += 1;
            counter.Text = "🧄 Garlics = " + garlics_count;
            sahText2.Text = name + ", as you know garlic is the greatest weakness of vampires so to keep yourself \nsafe, your task " + t_num + " is to find the garlic powder int the house. \nWhere do you think the garlic powder can be in the house?";
            answer1.Text = "";

            submit1.Parent = stayAtHomeSlide2;
            answer1.Parent = stayAtHomeSlide2;
            sahText2.Parent = stayAtHomeSlide2;
            quit.Parent = stayAtHomeSlide2;
            counter.Parent = stayAtHomeSlide2;
        }

        private void garlic_inc()
        {
            garlicIncText.Visible = true;

            garlics_count += 1;
            counter.Text = "🧄 Garlics = " + garlics_count;
            garlicIncText.Text = "Congratulations! You have earned an extra garlic 🧄";
        }
        
        private void garlic_dec()
        {
            garlicDecText.Visible = true;

            garlics_count -= 1;
            counter.Text = "🧄 Garlics = " + garlics_count;
            garlicDecText.Text = "Ooopppsss! You have lost a garlic 🧄";
        }

        private void garlic_riddle()
        {
            answer2.Visible = true;
            sahText3.Visible = true;

            string[] riddles = { "I’m white as snow, cold as ice, and my touch makes vampires think twice.\nWhat am I?", "I have a strong smell, white and small. Vampires fear me most of all.\nWhat am I?", "I grow in the ground, my scent is strong. To keep vampires away, I belong.\nWhat am I?", "I’m used in food to add some zest, but vampires think I’m far from the best.\nWhat am I?", "I’m a clove, but not for love. Vampires fear me from above.\nWhat am I?", "Hang me by the door, I’ll do my trick. Vampires won’t come near, not even a lick.\nWhat am I?", "I’m white and pungent, I make you tear, but to vampires, I’m their biggest fear.\nWhat am I?", "I’m used in sauces, soups, and bread, but I keep vampires filled with dread.\nWhat am I?", "I’m a kitchen staple, it’s clear, but I’m also a vampire’s worst fear.\nWhat am I?", "My smell is strong, I’m not a delight, but I keep vampires away at night.\nWhat am I?", "I’m not a weapon or a spell, yet I keep vampires away so well.\nWhat am I?" };
            Random random_riddle = new Random();
            int index_num = random_riddle.Next(riddles.Length);


            sahText3.Text = riddles[index_num];
            answer2.Text = "";
        }

        private void pattern_riddle()
        {
            sahText6.Visible = true;
            answer3.Visible = true;

            int[,] patterns = new int[10, 2]
            {
                { 2, 2 }, { 3, 3 }, { 5, 2 }, { 7, 3 }, { 10, 5 },{ 1, 4 }, { 6, 2 }, { 4, 3 }, { 8, 2 }, { 9, 3 }
            };
            Random Random_pattern = new Random();
            int index_num = Random_pattern.Next(0, 10);
            int start = patterns[index_num, 0];
            int multiplier = patterns[index_num, 1];
            int first = start;
            int second = first * multiplier;
            int third = second * multiplier;
            pattern_answer = Convert.ToString(third * multiplier);

            sahText6.Text = $"Pattern: {first}, {second}, {third}, ...?";
            answer3.Text = "";
        }

        private void submit1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(answer1.Text))
            {
                MessageBox.Show("Complete task "+t_num);
            }
            else
            {
                stayAtHomeSlide2.Visible = false;
                sahText2.Visible = false;
                answer1.Visible = false;
                submit1.Visible = false;

                attack();
                t_num += 1;
                if (answer1.Text == "Kitchen" || answer1.Text == "KITCHEN" || answer1.Text == "kitchen")
                {
                    //task 02
                    stayAtHomeSlide3.Visible = true;
                    sahText4.Visible = true;
                    submit2.Visible = true;
                    
                    garlic_inc();
                    garlic_riddle();
                    sahText4.Text = "To protect your home, sprinkle garlic powder at the front door. This barrier\nwill keep lurking vampires away. Act quickly and carefully—your safety \ndepends on it! Solve the riddle to complete the task" + t_num + ":";

                    sahText4.Parent = stayAtHomeSlide3;
                    sahText3.Parent = stayAtHomeSlide3;
                    garlicIncText.Parent = stayAtHomeSlide3;
                    answer2.Parent = stayAtHomeSlide3;
                    counter.Parent = stayAtHomeSlide3;
                    quit.Parent = stayAtHomeSlide3;
                    submit2.Parent = stayAtHomeSlide3;
                }
                else
                {
                    //task 03
                    bedroomSlide1.Visible = true;
                    sahText5.Visible = true;
                    submit3.Visible = true;

                    garlic_dec();
                    pattern_riddle();
                    sahText5.Text = "Secure your home by locking all doors and windows using the automated lock system.\nThis will create a strong barrier against any vampire threats.\nStay alert and act fast! To solve task " + t_num + " solve this pattern:";

                    submit3.Parent = bedroomSlide1;
                    garlicDecText.Parent = bedroomSlide1;
                    sahText5.Parent = bedroomSlide1;
                    sahText6.Parent = bedroomSlide1;
                    answer3.Parent = bedroomSlide1;
                    counter.Parent = bedroomSlide1;
                    quit.Parent = bedroomSlide1;
                }
            }
        }

        private void submit2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(answer2.Text))
            {
                MessageBox.Show("Complete task " + t_num);
            }
            else
            { 
                //task 03
                stayAtHomeSlide3.Visible = false;
                submit2.Visible = false;
                stayAtHomeSlide4.Visible = true;
                sahText5.Visible = true;
                submit3.Visible = true;

                attack();
                t_num += 1;
                if (answer2.Text == "garlic" || answer2.Text == "GARLIC" || answer2.Text == "Garlic")
                {
                    garlic_inc();
                    garlicIncText.Parent = stayAtHomeSlide4;
                }
                else
                {
                    garlic_dec();
                    garlicDecText.Parent = stayAtHomeSlide4;
                }
                pattern_riddle();
                sahText5.Text = "Secure your home by locking all doors and windows using the automated lock system.\nThis will create a strong barrier against any vampire threats.\nStay alert and act fast! To solve task " + t_num + " solve this pattern:";

                sahText5.Parent = stayAtHomeSlide4;
                submit3.Parent = stayAtHomeSlide4;
                sahText6.Parent = stayAtHomeSlide4;
                answer3.Parent = stayAtHomeSlide4;
                quit.Parent = stayAtHomeSlide4;
                counter.Parent = stayAtHomeSlide4;
            }
        }

        private void fire_riddle()
        {
            sahText8.Visible = true;
            answer4.Visible = true;
            
            string[] FireRiddle = { "What is a rapid chemical reaction that produces heat, light, and smoke? \na) Water\r\nb) Wind\r\nc) Ice\r\nd) Fire", "What is commonly used for warmth, cooking, or signaling?\na) Paper\r\nb) Stone\r\nc) Oil\r\nd) Fire", "What can be started using matches, lighters, or friction?\na) Smoke\r\nb) Fire\r\nc) Air\r\nd) Spark", " What should you extinguish immediately to prevent spreading?\na) Wind\r\nb) Dust\r\nc) Fire\r\nd) Water", "What is the term for a combustion process that produces flames?\na) Fire\r\nb) Steam\r\nc) Shadow\r\nd) Lightning", "What is often found at the center of a camp for cooking or warmth?\na) Fire\r\nb) Grass\r\nc) Tent\r\nd) Tree", "What do firefighters work hard to control or put out?\na) Earthquake\r\nb) Storm\r\nc) Fire\r\nd) Flood", "What is the destructive element involved in a wildfire?\na) Fire\r\nb) Fog\r\nc) Rain\r\nd) Snow", "What is an essential part of a bonfire or torch?\na) Sand\r\nb) Rope\r\nc) Fire\r\nd) Stone" };
            Random random_fireRiddle = new Random();
            int index_num = random_fireRiddle.Next(FireRiddle.Length);

            sahText8.Text = FireRiddle[index_num];
            answer4.Text = "";
        }


        private void silver_weapon()
        {
            sahText10.Visible = true;
            answer5.Visible = true;
           
            string[] SilverWeaponRiddle = { "I gleam under moonlight, cold and pure, In my touch,\nno fiend can endure. A dagger, a bullet, or a chain,\nTo the undead, I bring only pain. What am I?", "I’m forged in fire, yet I burn no flesh, Against dark foes, my bite is fresh.\nThough not alive, I slay with grace, My name’s been feared\nin every place. What am I?", "I’m not of steel, yet sharper still, A vampire’s doom,\nby hunter’s will. I pierce the heart,I break the bone,\nAgainst the cursed, I stand alone. What am I?", "Born of the earth, I carry the moon’s light,\nIn the hands of a hunter, I bring the night. To those who shun\nthe holy and bright, I am a weapon of unyielding might. What am I?", "I shine with purity, though lifeless I be, From the undeath's\ntorment, I set the world free. In bullets or blades, I fulfill my quest,\nTo vanquish the night and give mortals rest. What am I?" };
            Random random_WeaponRiddle = new Random();
            int index_num = random_WeaponRiddle.Next(SilverWeaponRiddle.Length);

            sahText10.Text = SilverWeaponRiddle[index_num];
            answer5.Text = "";
        }

        private void submit3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(answer3.Text))
            {
                MessageBox.Show("Complete task " + t_num);
            }
            else
            {                
                bedroomSlide1.Visible = false;
                sahText5.Visible = false;
                submit3.Visible = false;

                attack();
                t_num += 1;
                if (answer3.Text == pattern_answer)
                {
                    //task 04
                    stayAtHomeSlide4.Visible = false;
                    sahText7.Visible = true;
                    stayAtHomeSlide5.Visible = true;
                    submit4.Visible = true;

                    garlic_inc();
                    sahText7.Text = "Light the chimney with fire to create a protective barrier.\nThe smoke will help keep the vampires at bay.\n Answer the quiz to complete task " + t_num + ":";
                    fire_riddle();

                    sahText7.Parent = stayAtHomeSlide5;
                    sahText8.Parent = stayAtHomeSlide5;
                    answer4.Parent = stayAtHomeSlide5;
                    quit.Parent = stayAtHomeSlide5;
                    counter.Parent = stayAtHomeSlide5;
                    submit4.Parent = stayAtHomeSlide5;
                    garlicIncText.Parent = stayAtHomeSlide5;
                }
                else
                {
                    //task 05
                    sahText5.Visible = false;
                    submit3.Visible = false;
                    sahText6.Visible = false;
                    answer3.Visible = false;
                    garlicIncText.Visible = false;
                    sahText9.Visible = true;
                    stayAtHomeSlide4.Visible = true;
                    submit5.Visible = true;

                    garlic_dec();
                    sahText9.Text = "Search the house to find a weapon. You'll need it to defend \nyourself against any lurking vampires. Time is critical—choose wisely!. \n Answer the quiz to complete task " + t_num + ":";
                    silver_weapon();

                    sahText10.Parent = stayAtHomeSlide4;
                    sahText9.Parent = stayAtHomeSlide4;
                    answer5.Parent = stayAtHomeSlide4;
                    quit.Parent = stayAtHomeSlide4;
                    counter.Parent = stayAtHomeSlide4;
                    submit5.Parent = stayAtHomeSlide4;
                    garlicDecText.Parent = stayAtHomeSlide4;
                }

            }
        }

        private void submit4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(answer4.Text))
            {
                MessageBox.Show("Complete task " + t_num);
            }
            else
            {   
                //task 05
                sahText7.Visible = false;
                stayAtHomeSlide5.Visible = false;
                submit4.Visible = false;
                stayAtHomeSlide6.Visible = true;
                sahText9.Visible = true;
                submit5.Visible = true;

                attack();
                t_num += 1;
                if (answer4.Text == "fire" || answer4.Text == "FIRE" || answer4.Text == "Fire")
                {
                    garlic_inc();
                    garlicIncText.Parent = stayAtHomeSlide6;
                }
                else
                {
                    garlic_dec();
                    garlicDecText.Parent = stayAtHomeSlide6;
                }

                sahText9.Text = "Search the house to find a weapon. You'll need it to defend \nyourself against any lurking vampires. Time is critical—choose wisely!. \n Answer the quiz to complete task " + t_num + ":";
                silver_weapon();

                sahText9.Parent = stayAtHomeSlide6;
                sahText10.Parent = stayAtHomeSlide6;
                answer5.Parent = stayAtHomeSlide6;
                quit.Parent = stayAtHomeSlide6;
                counter.Parent = stayAtHomeSlide6;
                submit5.Parent = stayAtHomeSlide6;
            }
        }

        private void bat_riddles()
        {
            sahText11.Visible = true;
            answer6.Visible = true;
            
            string[] num_Bat = { "The vampire watched as a bat flew across the moonlit sky. \nThe castle’s rafters echoed with the soft flapping of a bat’s wings. \"What a clever little bat,\" he muttered, admiring its grace. \nThe bat perched near the window, its beady eyes glinting. In the silence, the bat became his only companion. \nAs dawn approached, the bat disappeared into the shadows. He wondered if the bat had come as a messenger. The vampire smiled, \nfeeling a strange kinship with the bat.", " A bat swooped low over the crypt’s entrance, startling the intruders. The vampire smirked, \nknowing the bat was only the beginning of their fears. Another bat joined, circling above the frightened group.\nThe flurry of bat wings grew louder as they advanced. \"It’s just a bat!\" one shouted,\nthough his voice trembled. A bat landed on the elder vampire’s shoulder,\nas if seeking protection. The hunters turned and fled, chased by the persistent bat. Once again,\nthe bat proved its loyalty to the night.", " In the ancient tower, a bat flitted from one corner to the next. The vampire reached out,\nand the bat settled on his hand. \"You are a curious creature, bat,\" he said softly.\nThe bat tilted its head, as if understanding his words. Together, they gazed out at the moon,\nthe bat remaining still. He released the bat, watching it glide effortlessly into the dark.\nAnother bat joined the first, their wings brushing like whispers. The night felt alive,\nthanks to the mysterious presence of the bat.", "The vampire’s chamber was filled with the sound of bat wings. A bat rested on the\nchandelier, its small body silhouetted. Another bat hung upside down, watching with unblinking eyes.\n\"You are welcome here, bat,\" the vampire said, his voice echoing. The bat’s shadow danced on the walls,\neerie yet comforting. He traced the image of a bat carved into the stone\nbeside him. Soon, the bat left, replaced by yet another arriving guest. For the vampire,\nevery bat was a herald of the night’s power.", "The hunter entered the cavern, his path guided by the cry of a bat.\nThe vampire watched from the shadows as the bat led him astray. A second bat swooped close, adding to the hunter’s\nconfusion. The flapping wings of a bat echoed through the labyrinth of tunnels. Suddenly, a bat landed\non his shoulder, and he froze in fear. The vampire chuckled as the bat flew off into the darkness.\nAnother bat appeared, sealing the hunter’s fate. The final sound he heard was the eerie\nscreech of the bat." };
            Random random_numberBat = new Random();
            int index_num = random_numberBat.Next(num_Bat.Length);

            bat = "6";
            sahText11.Text = num_Bat[index_num];
            answer6.Text = "";

        }
        private void blessed_water_riddles()
        {
            answer7.Visible = true;
            sahText13.Visible = true;
            
            string[] HolyWater = { "I’m often sprinkled in sacred rites, To cleanse and purify in holy sights.\nWhat am I called, another name you’ll see, A sign of grace and sanctity?", "In churches and temples, I’m found with care, A symbol of faith,\nbeyond compare. What’s my other name, so divine, Used in rituals, holy and fine?", "I’m poured or sprinkled, a sacred embrace, To wash away sins, leaving no trace.\nKnown as holy, but another I’m called,Can you name me,\nrevered and enthralled?", "Used in baptism, a sacred flow, I’m blessed and pure,\nas many know. What’s my name, often spoken, In rituals\nwhere faith is unbroken?", "I’m sanctified for sacred tasks, My other name is what this quiz asks.\nA sign of cleansing,peace, and grace, What am I \ncalled in this holy space?" };
            Random random_HolyWater = new Random();
            int index_num = random_HolyWater.Next(HolyWater.Length);
            sahText13.Text = HolyWater[index_num];
            answer7.Text = "";
        }

        private void submit5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(answer5.Text))
            {
                MessageBox.Show("Complete task " + t_num);
            }
            else
            {
                stayAtHomeSlide6.Visible = false;
                submit5.Visible = false;

                attack();
                t_num += 1;
                if (answer5.Text == "silver weapon" || answer5.Text == "Silver weapon" || answer5.Text == "SILVER WEAPON" || answer5.Text == "Silver Weapon")
                {
                    //task 07
                    stayAtHomeSlide6.Visible = false;
                    stayAtHomeSlide4 .Visible = false;
                    sahText9.Visible = false;
                    sahText10.Visible = false;
                    sahText9.Visible = false;
                    answer5.Visible = false;
                    submit7.Visible = true;                    
                    stayAtHomeSlide7.Visible = true;
                    sahText12.Visible = true;

                    garlic_inc();
                    bat_riddles();
                    sahText12.Text = "Quickly find a hiding spot to stay safe. Look for a secure and inconspicuous place where you can \navoid detection by vampires. Choose wisely and stay quiet!";

                    submit7.Parent = stayAtHomeSlide7;
                    sahText12.Parent = stayAtHomeSlide7;
                    garlicIncText.Parent = stayAtHomeSlide7;
                    sahText11.Parent = stayAtHomeSlide7;
                    answer6.Parent = stayAtHomeSlide7;
                    quit.Parent = stayAtHomeSlide7;
                    counter.Parent = stayAtHomeSlide7;
                }
                else
                {   
                    //task 06 
                    sahText9.Visible = false;
                    sahText10.Visible = false;
                    stayAtHomeSlide6.Visible = false;
                    stayAtHomeSlide4.Visible = false;
                    submit6.Visible = true;
                    stayAtHomeSlide8.Visible = true;
                    sahText14.Visible = true;
                    sahText13.Visible = true;

                    garlic_dec();
                    blessed_water_riddles();
                    sahText14.Text = "Search the house carefully to find the holy water. It's a powerful tool\nagainst vampires, so locate it quickly before danger finds you!";

                    submit6.Parent = stayAtHomeSlide8;
                    counter.Parent = stayAtHomeSlide8;
                    sahText14.Parent = stayAtHomeSlide8;
                    answer7.Parent = stayAtHomeSlide8;
                    sahText13.Parent = stayAtHomeSlide8;
                    garlicDecText.Parent = stayAtHomeSlide8; 
                    quit.Parent = stayAtHomeSlide8;

                }                
            }
        }

        private void submit6_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(answer7.Text))
            {
                MessageBox.Show("Complete task " + t_num);
            }
            else
            {
                //task 07
                stayAtHomeSlide8.Visible = false;
                stayAtHomeSlide4.Visible=false;
                stayAtHomeSlide6.Visible=false;
                sahText14.Visible = false;
                submit6.Visible = false;
                answer7.Visible = false;
                sahText13.Visible = false;
                stayAtHomeSlide7.Visible = false;
                stayAtHomeSlide9.Visible = true;
                sahText12.Visible = true;
                submit7.Visible = true;

                attack();
                t_num += 1;
                if (answer7.Text == "blessed water" || answer7.Text == "BLESSED WATER" || answer7.Text == "Blessed Water")
                {
                    garlic_inc();
                    garlicIncText.Parent = stayAtHomeSlide9;
                }
                else
                {
                    garlic_dec();
                    garlicDecText.Parent = stayAtHomeSlide9;
                }
                bat_riddles();
                sahText12.Text = "Quickly find a hiding spot to stay safe. Look for a secure and inconspicuous place where you can \navoid detection by vampires. Choose wisely and stay quiet!";

                submit7.Parent = stayAtHomeSlide9;
                answer6.Parent = stayAtHomeSlide9;
                sahText11.Parent = stayAtHomeSlide9;
                submit7.Parent = stayAtHomeSlide9;
                sahText12.Parent = stayAtHomeSlide9;
                quit.Parent = stayAtHomeSlide9;
                counter.Parent = stayAtHomeSlide9;
            }
        }

        private void blood_riddles()
        {
            answer8.Visible = true;
            sahText16.Visible = true;

            string[] BloodRiddles = {"I flow within and keep you alive,\nCrimson rivers where cells thrive.\nWhat am I, essential to you,\nThe life source running through?","I’m sought by those with fangs to bite,\nRunning through veins, a vital sight.\nWhat am I, flowing red and warm,\nLife’s true essence, in its form?","Crimson and vital, I carry life,\nWithout me, existence faces strife.\nWhat am I, unseen and true,\nEssential to both me and you?","Vampires crave me in the night,\nWithout my flow, there’s no light.\nWhat am I, sustaining each day,\nYour heartbeat’s rhythm along the way?","I am shed in war, sought in lore,\nVital and red, I do much more.\nWhat am I, flowing deep inside,\nCarrying life with every stride?"};

            Random random_Blood = new Random();
            int index_num = random_Blood.Next(BloodRiddles.Length);
            sahText16.Text = BloodRiddles[index_num];
            answer8.Text = "";
        }


        private void submit7_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(answer6.Text))
            {
                MessageBox.Show("Complete task " + t_num);
            }
            else
            {
                //task 08
                stayAtHomeSlide7.Visible = false;
                sahText12.Visible = false;
                submit7.Visible = false;
                answer6.Visible = false;
                sahText11.Visible = false;
                stayAtHomeSlide10.Visible = true;
                sahText15.Visible = true;
                answer8.Visible = true;
                submit9.Visible = true;

                attack();
                t_num += 1;
                if (answer6.Text == "6")
                {
                    garlic_inc();
                    garlicIncText.Parent = stayAtHomeSlide10;
                }
                else
                {
                    garlic_dec();
                    garlicDecText.Parent = stayAtHomeSlide10;
                }

                sahText15.Text = "Turn off all the lights to avoid drawing attention.\nStay hidden in the darkness and keep yourself safe from any lurking threats!";
                blood_riddles();

                answer8.Parent = stayAtHomeSlide10;
                sahText15.Parent = stayAtHomeSlide10;
                sahText16.Parent = stayAtHomeSlide10;
                quit.Parent = stayAtHomeSlide10;
                counter.Parent = stayAtHomeSlide10;
                submit9.Parent = stayAtHomeSlide10;
            }
        }


        private void submit9_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(answer8.Text))
            {
                MessageBox.Show("Complete task " + t_num);
            }
            else
            { 
                //task 09
                submit8.Visible = false;
                submit9.Visible = false;
                stayAtHomeSlide10.Visible = false;
                sahText15.Visible = false;
                answer8.Visible = false;
                sahText16.Visible = false;
                stayAtHomeSlide11.Visible = true;
                sahText17.Visible = true;
                hideBtn.Visible = true;
                dontHideBtn.Visible = true;

                attack();
                t_num += 1;
                if(answer8.Text == "blood" || answer8.Text == "BLOOD" || answer8.Text == "Blood")
                {
                    garlic_inc();
                    garlicIncText.Parent = stayAtHomeSlide11;
                }
                else
                {
                    garlic_dec();
                    garlicDecText.Parent = stayAtHomeSlide11;
                }
                sahText17.Text = "Your task " + t_num + " is to hide at the safe spot";

                sahText17.Parent = stayAtHomeSlide11;
                hideBtn.Parent = stayAtHomeSlide11;
                dontHideBtn.Parent = stayAtHomeSlide11;
                garlicDecText.Parent = stayAtHomeSlide11;
                garlicIncText.Parent = stayAtHomeSlide11;
                quit.Parent = stayAtHomeSlide11;
                counter.Parent = stayAtHomeSlide11;
            }
        }

        private void hideBtn_Click(object sender, EventArgs e)
        {
            garlicDecText.Visible = false;
            garlicIncText.Visible = false;
            sahText17.Visible = false;
            hideBtn.Visible = false;
            dontHideBtn.Visible = false;
            quit.Visible = false;
            counter.Visible = false;
            stayAtHomeSlide11.Visible = false;

            if (garlics_count >= 2)
            {
                survived.Visible = true;
                survivedText.Visible = true;
                restart.Visible = true;

                survivedText.Text = "Congratulations! You Survived the Day";

                survivedText.Parent = survived;
                restart.Parent = survived;
            }
            else
            {
                attacked.Visible = true;
                survivedText.Visible = true;
                restart.Visible = true;

                survivedText.Text = "Attacked by the Vampires!! \n you did't survive the day";

                survivedText.Parent = attacked;
                restart.Parent = attacked;
            }
        }


        private void dontHideBtn_Click(object sender, EventArgs e)
        {
            attacked.Visible = true;
            survivedText.Visible = true;
            garlicDecText.Visible = false;
            garlicIncText.Visible = false;
            sahText17.Visible = false;
            hideBtn.Visible = false;
            dontHideBtn.Visible = false;
            quit.Visible = false;
            counter.Visible = false;
            stayAtHomeSlide11.Visible = false;
            restart.Visible = true;

            survivedText.Text = "Attacked by the Vampires!! \n you did't survive the day";

            survivedText.Parent = attacked;
            restart.Parent = attacked;
        }

        private void restart_Click(object sender, EventArgs e)
        {
            quit_Click(sender, e);
        }

        private void quit_Click(object sender, EventArgs e)
        {
            reset();

            veIntro.Visible = true;
            playBtn.Visible = true;

            garlics_count = 5;
            counter.Text = "🧄 Garlics = " + garlics_count;
        }

        private void reset()
        {
            veSlide1.Visible = false;
            userName.Visible = false;
            enterName.Visible = false;
            submitBtn.Visible = false;
            veSlide2.Visible = false;
            n1.Visible = false;
            quit.Visible = false;
            counter.Visible = false;
            veText1.Visible = false;
            stayAtHomeSlide1.Visible = false;
            sahText1.Visible = false;
            startBtn.Visible = false;
            stayAtHomeSlide2.Visible = false;
            sahText2.Visible = false;
            answer1.Visible = false;
            sahText3.Visible = false;
            stayAtHomeSlide3.Visible = false;
            garlicIncText.Visible = false;
            bedroomSlide1.Visible = false;
            answer2.Visible = false;
            submit1.Visible = false;
            garlicDecText.Visible = false;
            sahText4.Visible = false;
            answer3.Visible = false;
            sahText5.Visible = false;
            sahText6.Visible = false;
            stayAtHomeSlide4.Visible = false;
            submit2.Visible = false;
            submit3.Visible = false;
            stayAtHomeSlide5.Visible = false;
            answer4.Visible = false;
            sahText7.Visible = false;
            sahText8.Visible = false;
            submit4.Visible = false;
            answer5.Visible = false;
            sahText9.Visible = false;
            sahText10.Visible = false;
            stayAtHomeSlide6.Visible = false;
            submit5.Visible = false;
            sahText11.Visible = false;
            sahText12.Visible = false;
            sahText13.Visible = false;
            sahText14.Visible = false;
            answer6.Visible = false;
            answer7.Visible = false;
            stayAtHomeSlide7.Visible = false;
            stayAtHomeSlide8.Visible = false;
            submit7.Visible = false;
            stayAtHomeSlide9.Visible = false;
            submit6.Visible = false;
            answer8.Visible = false;
            sahText15.Visible = false;
            sahText16.Visible = false;
            stayAtHomeSlide10.Visible = false;
            submit8.Visible = false;
            stayAtHomeSlide11.Visible = false;
            submit9.Visible = false;
            hideBtn.Visible = false;
            dontHideBtn.Visible = false;
            sahText17.Visible = false;
            survivedText.Visible = false;
            survived.Visible = false;
            attacked.Visible = false;
            restart.Visible = false;
        }

    }
}
