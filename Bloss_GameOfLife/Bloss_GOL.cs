using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/////////////////////////////////////////////////////////////////////////////////////////////////
/// Name: Justin Bloss
/// Date: 4/9/19
/// Class: CIS 244
/// Project: Game of Life - Part 2
/// Purpose: The purpose of this project is to replicate a Game of Life machine, where cells are created based on pre-set
/// patterns that the user can choose on with pre-sets and their own files. Cells are accounted for based on age, shape and
/// whether or not they are alive. The user can submit and save their own patterns to see the pattern outcome.
///////////////////////////////////////////////////////////////////////////////////////////////
namespace Bloss_GameOfLife
{
    public partial class Bloss_GOL : Form
    {
        // declaring instance variables and constants
        
        private Graphics graphics;
        private Brush gridBrush;
        private Pen gridPen;
        private GOLCell[,] grid;
        private const int ROWS = 42;
        private const int COLS = 62;
        private const int SIZE = 10;
        private int deadCellCount, year0CellCount, year1CellCount, year2CellCount, year3CellCount, year4UPCellCount, genCount;

        public Bloss_GOL()
        {
            InitializeComponent();
            grid = new GOLCell[ROWS, COLS];
            gridBrush = new SolidBrush(Color.White);
            gridPen = new Pen(Color.Black, 1);
            graphics = this.CreateGraphics();
        }
            
        // on button "Create Grid" click
        private void createGrid_Click(object sender, EventArgs e)
        {
            // if clear grid is checked
            if (radInfinite.Checked == true)
            {
                // resets counters and sets them equal to label counterparts
                genCount = 0;
                lblGenerationNum.Text = genCount.ToString();
                deadCellCount = 0;
                lblDeadCell.Text = deadCellCount.ToString();
                year0CellCount = 0;
                lblYellowCell.Text = year0CellCount.ToString();
                year1CellCount = 0;
                lblGreenCell.Text = year1CellCount.ToString();
                year2CellCount = 0;
                lblBlueCell.Text = year2CellCount.ToString();
                year3CellCount = 0;
                lblMagentaCell.Text = year3CellCount.ToString();
                year4UPCellCount = 0;
                lblRedCell.Text = year4UPCellCount.ToString();
                // calls CreateEmptyGrid function
                CreateInfinite();
                // calls DrawGrid function
                DrawGrid();
            }
            // else if Pulsar is checked
            else if (radPulsar.Checked == true)
            {
                // resets counters and sets them equal to label counterparts
                genCount = 0;
                lblGenerationNum.Text = genCount.ToString();
                deadCellCount = 0;
                lblDeadCell.Text = deadCellCount.ToString();
                year0CellCount = 0;
                lblYellowCell.Text = year0CellCount.ToString();
                year1CellCount = 0;
                lblGreenCell.Text = year1CellCount.ToString();
                year2CellCount = 0;
                lblBlueCell.Text = year2CellCount.ToString();
                year3CellCount = 0;
                lblMagentaCell.Text = year3CellCount.ToString();
                year4UPCellCount = 0;
                lblRedCell.Text = year4UPCellCount.ToString();
                // calls CreatePulsar function
                CreatePulsar();
                // calls DrawGrid function
                DrawGrid();
            }
            // else if Beacon is checked
            else if (radBeacon.Checked == true)
            {
                // resets counters and sets them equal to label counterparts
                genCount = 0;
                lblGenerationNum.Text = genCount.ToString();
                deadCellCount = 0;
                lblDeadCell.Text = deadCellCount.ToString();
                year0CellCount = 0;
                lblYellowCell.Text = year0CellCount.ToString();
                year1CellCount = 0;
                lblGreenCell.Text = year1CellCount.ToString();
                year2CellCount = 0;
                lblBlueCell.Text = year2CellCount.ToString();
                year3CellCount = 0;
                lblMagentaCell.Text = year3CellCount.ToString();
                year4UPCellCount = 0;
                lblRedCell.Text = year4UPCellCount.ToString();
                // calls CreateBeacon function
                CreateBeacon();
                // calls DrawGrid function
                DrawGrid();
            }
            // else if Random is checked
            else if (radRandom.Checked == true)
            {
                // resets counters and sets them equal to label counterparts
                genCount = 0;
                lblGenerationNum.Text = genCount.ToString();
                deadCellCount = 0;
                lblDeadCell.Text = deadCellCount.ToString();
                year0CellCount = 0;
                lblYellowCell.Text = year0CellCount.ToString();
                year1CellCount = 0;
                lblGreenCell.Text = year1CellCount.ToString();
                year2CellCount = 0;
                lblBlueCell.Text = year2CellCount.ToString();
                year3CellCount = 0;
                lblMagentaCell.Text = year3CellCount.ToString();
                year4UPCellCount = 0;
                lblRedCell.Text = year4UPCellCount.ToString();
                // calls CreateRandom function
                CreateRandom();
                // calls DrawGrid function
                DrawGrid();
            }
            // else if Open File is checked
            else if(radOF.Checked == true)
            {
                // resets counters and labels associated with them
                genCount = 0;
                lblGenerationNum.Text = genCount.ToString();
                deadCellCount = 0;
                lblDeadCell.Text = deadCellCount.ToString();
                year0CellCount = 0;
                lblYellowCell.Text = year0CellCount.ToString();
                year1CellCount = 0;
                lblGreenCell.Text = year1CellCount.ToString();
                year2CellCount = 0;
                lblBlueCell.Text = year2CellCount.ToString();
                year3CellCount = 0;
                lblMagentaCell.Text = year3CellCount.ToString();
                year4UPCellCount = 0;
                lblRedCell.Text = year4UPCellCount.ToString();
                // calls a function to read in the data file
                ReadDataFile();
                // calls a function to draw the grid
                DrawGrid();
            }
        }

        // WORK IN PROGRESS - COME BACK TO THIS!!
        public void ReadDataFile()
        {
            // declaring a new streamreader named reader that reads in the text file
            StreamReader reader = new StreamReader(txtPath.Text);
            // class var row
            int row = 0;
            // while not the end of stream of the streamreader
            while(!reader.EndOfStream)
            {
                // reads the line from the file and stores it in a string currentLine
                string currentLine = reader.ReadLine();
                // splits the string currentLine by each space and stores it in a string array lineArray
                string[] lineArray = currentLine.Split(' ');

                // for loop that reads through the string array
                    for (int j = 0; j < lineArray.Length; j++)
                    {
                    // creates a new rectangle with pre-set size, height and width are the same
                        Rectangle cell = new Rectangle(j * SIZE, row * SIZE, SIZE, SIZE);
                    // creates a new instance of GOLCell with parameters of Rectangle cell, -1 for age value and 0 for alive value
                        grid[row, j] = new GOLCell(cell, -1, 0);
                        // sets the grid of row and j to the string value in lineArray of j being parsed
                        grid[row, j].Alive = int.Parse(lineArray[j]);
                    }
                    // increments row var
                    row++;
            }
            reader.Close();
        }

        // Create a Beacon
        public void CreateBeacon()
        {
            // int array for a Beacon shape
            int[,] Beacon = new int[4, 6] {{0,1,1,0,0,0},
                                          {0,1,1,0,0,0},
                                          {0,0,0,1,1,0},
                                          {0,0,0,1,1,0}};

            // for loop to cycle through Rows
            for (int i = 0; i < ROWS; i++)
            {
                // for loop to cycle through columns
                for (int j = 0; j < COLS; j++)
                {
                    // creates a new rectangle with preset size, height and width
                    Rectangle cell = new Rectangle(j * SIZE, i * SIZE, SIZE, SIZE);
                    // creates a new instance of a GOLCell with parameters of Rectangle cell, -1 for age value and 0 for alive value
                    grid[i, j] = new GOLCell(cell, -1, 0);

                    // sets beacon to the middle of the grid
                    if (i >= 18 && i < 22 && j >= 24 && j < 30)
                    {
                        grid[i, j].Alive = Beacon[i - 18, j - 24];
                    }
                }
            }
        }

        // Draws an empty grid
        public void DrawGrid()
        {
            // for loop to cycle through ROWS int
            for (int i = 0; i < ROWS; i++)
            {
                // for loop to cycle through COLS int
                for (int j = 0; j < COLS; j++)
                {
                    // if the cell is alive
                    if (grid[i, j].Alive == 1)
                    {
                        // creates a new brush that is yellow to indicate an alive cell
                        gridBrush = new SolidBrush(Color.Yellow);
                        year0CellCount++;
                        lblYellowCell.Text = year0CellCount.ToString();
                    }
                    else
                    {
                        // if cell is not alive, will color the cell white
                        gridBrush = new SolidBrush(Color.White);
                        deadCellCount++;
                        lblDeadCell.Text = deadCellCount.ToString();
                    }
                    // draws and colors the cells
                    graphics.FillRectangle(gridBrush, grid[i, j].Cell);
                    graphics.DrawRectangle(gridPen, grid[i, j].Cell);
                }
            }
            genCount++;
            lblGenerationNum.Text = genCount.ToString();
        }

        // Creates a pulsar
        public void CreatePulsar()
        {
            // int array for a pulsar shape
            int[,] Pulsar = new int[13, 13] {{0,0,1,1,1,0,0,0,1,1,1,0,0},
                                            {0,0,0,0,0,0,0,0,0,0,0,0,0},
                                            {1,0,0,0,0,1,0,1,0,0,0,0,1},
                                            {1,0,0,0,0,1,0,1,0,0,0,0,1},
                                            {1,0,0,0,0,1,0,1,0,0,0,0,1},
                                            {0,0,1,1,1,0,0,0,1,1,1,0,0},
                                            {0,0,0,0,0,0,0,0,0,0,0,0,0},
                                            {0,0,1,1,1,0,0,0,1,1,1,0,0},
                                            {1,0,0,0,0,1,0,1,0,0,0,0,1},
                                            {1,0,0,0,0,1,0,1,0,0,0,0,1},
                                            {1,0,0,0,0,1,0,1,0,0,0,0,1},
                                            {0,0,0,0,0,0,0,0,0,0,0,0,0},
                                            {0,0,1,1,1,0,0,0,1,1,1,0,0}};

            // for loop to cycle through rows
            for (int i = 0; i < ROWS; i++)
            {
                // for loop to cycle through columns
                for (int j = 0; j < COLS; j++)
                {
                    // creates a new rectangle with pre set size, height and width are the same
                    Rectangle cell = new Rectangle(j * SIZE, i * SIZE, SIZE, SIZE);
                    // creates a new instance of a GOLCell with parameters of Rectangle cell, -1 for age value, and 0 for alive value
                    grid[i, j] = new GOLCell(cell, -1, 0);

                    // sets the pulsar to the middle of the grid
                    if (i >= 14 && i < 27 && j >= 20 && j < 33)
                    {
                        grid[i, j].Alive = Pulsar[i - 14, j - 20];
                    }
                }
            }
        }

        // Try parses input in textbox for # of generations, runs grid through array equal to the input in textbox and updates grid
        // and cells based on CountNeighbor and DetermineCellState functions.
        private void runGenerations_Click(object sender, EventArgs e)
        {
            // declaring local var
            int genResults = 0;

            // int.TryParse for invalid input by user, checks to see if value entered is an integer
            if (int.TryParse(txtGenerations.Text, out genResults))
            {
                // for loop that goes through a loop based on the integer entered by the user
                for (int i = 0; i < genResults; i++)
                {
                    CountNeighbor();
                    UpdateGrid();
                    DetermineCellState();
                    lblGenerationNum.Text = genCount.ToString();
                    lblDeadCell.Text = deadCellCount.ToString();
                    lblYellowCell.Text = year0CellCount.ToString();
                    lblGreenCell.Text = year1CellCount.ToString();
                    lblBlueCell.Text = year2CellCount.ToString();
                    lblMagentaCell.Text = year3CellCount.ToString();
                    lblRedCell.Text = year4UPCellCount.ToString();
                }
            }
            // else if the input entered is not valid
            else
            {
                // displays a message box prompting user to enter a valid input
                MessageBox.Show("Please enter a valid input.");
            }
        }

        // Runs through a single generation of the grid and calls functions to determine what cells will be colored in 
        // as well as their count.
        private void btnSingleGen_Click(object sender, EventArgs e)
        {
            CountNeighbor();
            UpdateGrid();
            DetermineCellState();
            lblGenerationNum.Text = genCount.ToString();
            lblDeadCell.Text = deadCellCount.ToString();
            lblYellowCell.Text = year0CellCount.ToString();
            lblGreenCell.Text = year1CellCount.ToString();
            lblBlueCell.Text = year2CellCount.ToString();
            lblMagentaCell.Text = year3CellCount.ToString();
            lblRedCell.Text = year4UPCellCount.ToString();
        }

        // WORK IN PROGRESS - COME BACK TO THIS
        private void btnSave_Click(object sender, EventArgs e)
        {
            StreamWriter writer;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                writer = File.CreateText(saveFileDialog.FileName);
                for(int i=0; i<ROWS; i++)
                {
                    for(int j=0; j<COLS; j++)
                    {
                        writer.Write(grid[i, j].Alive+" ");
                    }
                    writer.WriteLine();
                }
                writer.Close();
            }
        }

        // WORK IN PROGRESS - COME BACK TO THIS
        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            // if OK is clicked on the file browser
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // sets the path and filename of the dialog box to a textbox for prep
                txtPath.Text = openFileDialog.FileName;   
            }  
        }

        // Creates an infinite
        public void CreateInfinite()
        {
            // int array for an infinite pattern
            int[,] Infinite = new int[5, 5] {{1,1,1,0,1},
                                             {1,0,0,0,0},
                                             {0,0,0,1,1},
                                             {0,1,1,0,1},
                                             {1,0,1,0,1}};

            // for loop to cycle through rows
            for (int i = 0; i < ROWS; i++)
            {
                // for loop to cycle through columns
                for (int j = 0; j < COLS; j++)
                {
                    // creates a new rectangle with preset size, height and width
                    Rectangle cell = new Rectangle(j * SIZE, i * SIZE, SIZE, SIZE);
                    // creates a new instance of a GOLCell with parameters of rectangle, -1 for age and 0 for alive value
                    grid[i, j] = new GOLCell(cell, -1, 0);

                    // centers the infinite pattern to the grid
                    if (i >= 19 && i < 24 && j >= 24 && j < 29)
                    {
                        grid[i, j].Alive = Infinite[i - 19, j - 24];
                    }
                }
            }
        }

        // Creates a random grid pattern
        public void CreateRandom()
        {
            // New Random var
            Random rnd = new Random();

            // goes through rows
            for (int i = 0; i < ROWS; i++)
            {
                // goes through columns
                for (int j = 0; j < COLS; j++)
                {
                    // int Random = random variable between 0 and 1
                    int Random = rnd.Next(0, 2);
                    // creates new cell with pre set height, width and size
                    Rectangle cell = new Rectangle(j * SIZE, i * SIZE, SIZE, SIZE);
                    // creates new GOLCell with parameters of rectangle cell, age of -1, and alive value of 0
                    grid[i, j] = new GOLCell(cell, -1, 0);
                    // if number in Random is equal to 1
                    if (Random == 1)
                    {
                        // the cell becomes alive
                        grid[i, j].Alive = 1;
                    }
                    // if number in Random is not 1
                    else
                    {
                        // the cell is dead
                        grid[i, j].Alive = 0;
                    }

                }
            }
        }    

        // the purpose of this function is to count the amount of living cell neighbors in the grid and determine whether or not those cells
        // will live or die come the next generation
        public void CountNeighbor()
        {
            // for loop to go through rows
            for(int i=2; i<ROWS-2; i++)
            {
                // for loop to go through columns
                for(int j=2; j<COLS-2; j++)
                {
                    // counts the amount of living neighbors and stores the value in an integer for further use
                    int liveNeighbor = grid[i - 1, j - 1].Alive + grid[i - 1, j].Alive + grid[i - 1, j + 1].Alive +
                                       grid[i, j - 1].Alive + grid[i,j + 1].Alive + grid[i + 1, j - 1].Alive +
                                       grid[i + 1, j].Alive + grid[i + 1, j + 1].Alive;
                    // if the cell on the grid is alive
                    if (grid[i,j].Alive == 1)
                    {
                        // if the amount of live neighbors is less than 2 or greater than 3
                        if(liveNeighbor < 2 || liveNeighbor > 3)
                        {
                            // the cell dies
                            grid[i, j].FutureState = 0;
                            // sets age to -1 for dead cell
                            grid[i, j].Age = -1;
                        }
                        // if the amount of live neighbors is equal to 2 or 3
                        else
                        {
                            // the cell stays alive
                            grid[i, j].FutureState = 1;
                        }
                    }
                    // if the cell is currently dead
                    else if (grid[i,j].Alive == 0)
                    {
                        // if the amount of living neighbors is equal to 3
                        if(liveNeighbor == 3)
                        {
                            // the cell becomes alive
                            grid[i, j].FutureState = 1;
                        }
                        // if the amount of living neighbors is anything other than 3
                        else
                        {
                            // the cell stays dead
                            grid[i, j].FutureState = 0;
                            // sets age to -1 for dead cell
                            grid[i, j].Age = -1;
                        }
                    }
                }
            }
        }

        // Goes through the grid and assigns the value of each cell that has a future state of 1 to the alive attribute of the cell
        public void UpdateGrid()
        {
            // goes through rows
            for (int i=0; i<ROWS; i++)
            {
                // goes through columns
                for(int j=0; j<COLS; j++)
                {
                    // assigns value of the future state of the current cell to the alive value of the current cell
                    grid[i, j].Alive = grid[i, j].FutureState;
                }
            }
        }

        // The purpose of this class is to determine the new age of a cell and set its new color
        public void DetermineCellState()
        {
            // resets cell counters
            deadCellCount = 0;
            lblDeadCell.Text = deadCellCount.ToString();
            year0CellCount = 0;
            lblYellowCell.Text = year0CellCount.ToString();
            year1CellCount = 0;
            lblGreenCell.Text = year1CellCount.ToString();
            year2CellCount = 0;
            lblBlueCell.Text = year2CellCount.ToString();
            year3CellCount = 0;
            lblMagentaCell.Text = year3CellCount.ToString();
            year4UPCellCount = 0;
            lblRedCell.Text = year4UPCellCount.ToString();

            // goes through rows
            for (int i=0; i<ROWS; i++)
            {
                // goes through columns
                for(int j=0; j<COLS; j++)
                {
                    // if the future state of a cell is 1
                    if(grid[i, j].FutureState == 1)
                    {
                        // increments age of cell
                        grid[i, j].Age++;
                        // if age is equal to 0:
                        if(grid[i, j].Age == 0)
                        {
                            // sets paintbrush to yellow
                            gridBrush = new SolidBrush(Color.Yellow);
                            // increments year0cellcount counter
                            year0CellCount++;
                        }
                        // else if age is equal to 1:
                        else if(grid[i,j].Age == 1)
                        {
                            // sets paintbrush to green
                            gridBrush = new SolidBrush(Color.Green);
                            // increments year 1 counter
                            year1CellCount++;
                        }
                        // else if age is 2
                        else if(grid[i,j].Age == 2)
                        {
                            // paintbrush set to blue
                            gridBrush = new SolidBrush(Color.Blue);
                            // increments year 2 counter
                            year2CellCount++;
                        }
                        // else if age is 3
                        else if(grid[i,j].Age == 3)
                        {
                            // sets paintbrush to magenta
                            gridBrush = new SolidBrush(Color.Magenta);
                            // increments year 3 counter
                            year3CellCount++;
                        }
                        // else if age is 4
                        else if(grid[i,j].Age >= 4)
                        {
                            // sets paintbrush to red
                            gridBrush = new SolidBrush(Color.Red);
                            // increments year 4 and up counter
                            year4UPCellCount++;
                        }
                    }
                    // else if future state is equal to 0
                    else
                    {
                        // sets paintbrush to white, indicating a dead cell
                        gridBrush = new SolidBrush(Color.White);
                        // increments dead cell count
                        deadCellCount++;
                    }
                    // draws and colors each rectangle with their color based on age and future state
                    graphics.FillRectangle(gridBrush, grid[i, j].Cell);
                    graphics.DrawRectangle(gridPen, grid[i, j].Cell);
                }
            }
            genCount++;
        } 
    }
}
