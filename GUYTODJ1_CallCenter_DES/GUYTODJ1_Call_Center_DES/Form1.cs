using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/*HEADER 
 * ||================================================================================================================================||
 * ||                                                PROGRAM: CALL CENTER - DISCRETE EVENT SIMULATOR                                 ||
 * ||                                                 CLASS: Form1.cs                                                                ||
 * ||                                                AUTHOR: DAMIEN GUYTON (GUYTODJ1)                                                ||
 * ||                                                 DATE: 14/07/2013                                                               ||
 * ||                                                                                                                                ||
 * || ______________________________________________________DESCRIPTION_____________________________________________________________ ||
 * ||             Form  class holds a the GUI controls and is the main area where all the methods that run the simulation are called ||
 * ||                                                                                                                                ||
 * ||__________________________________________________________BUGS__________________________________________________________________||
 * ||          the form locks up when running bceause i have desinged the program on a single thread                                 ||
 * ||                                                                                                                                ||
 * || __________________________________________________________NOTE_________________________________________________________________||
 * ||                      The word Calandar has inconsistent spelling throughout the program :(                                     ||
 * ||================================================================================================================================||
 */
namespace GUYTODJ1_Call_Center_DES
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Simulator theSim;
        SimulationDisplayDataSubject simulationData;
        SimulationDisplayDataSubject statsData; 
        StatsDataDisplayObserver statsDisplay;
        CalandarDataDisplayObserver calanderDisplay;
        OtherProductDataDisplayObserver otherQueueDisplay;
        CarStereoQueueDataDisplayObserver stereoQueueDisplay;
        GraphicsDisplayObserver graphicalDisplay;

        private void Form1_Load(object sender, EventArgs e)
        {
            //Initalize classes 
            simulationData = new SimulationDisplayDataSubject();
            statsData = new SimulationDisplayDataSubject();
            statsDisplay = new StatsDataDisplayObserver(StatsDataGridView, statsData);
            calanderDisplay = new CalandarDataDisplayObserver(CalanderDataGrid, simulationData);
            otherQueueDisplay = new OtherProductDataDisplayObserver(OtherQueueDataGridView, simulationData);
            stereoQueueDisplay = new CarStereoQueueDataDisplayObserver(StereoQueueDataGridView, simulationData);
            graphicalDisplay = new GraphicsDisplayObserver(graphicsSurface, simulationData);

        }//End Form Load

        private void setParameters()
        {
            //Set the gloabal parametes to the values on the form controls
            GlobalParameters.NUM_OTHER_REPS = Convert.ToInt32(otherRepNUD.Value);
            GlobalParameters.NUM_STEREO_REPS = Convert.ToInt32(stereoRepNUD.Value);
            GlobalParameters.CALL_TYPE_RATIO = Convert.ToDouble(productTypeNUD.Value);
            GlobalParameters.MAX_ON_HOLD = Convert.ToInt32(maxOnHoldNUD.Value);
            GlobalParameters.IVR_DELAY = Convert.ToDouble(ivrNUD.Value);
            GlobalParameters.OTHER_PRODUCT_CALL_PROCESSING_TIME = Convert.ToDouble(otherProductProcessingTimeNUD.Value);
            GlobalParameters.CAR_STEREO_CALL_PROCESSING_TIME = Convert.ToDouble(carStereoProcessingTimeNUD.Value);
            GlobalParameters.CALL_ARRIVAL_RATE = Convert.ToDouble(callIntervalNUD.Value);
            GlobalParameters.SPEED = Convert.ToInt32(tBarSpeed.Value);

        }//End Method

        private void btnRun_Click(object sender, EventArgs e)
        {
            //set the parameters 
            setParameters();

            //check wheter or not they are wanting graphical display or text based display
            ViewSelection();
            //create the simulation
            theSim = new Simulator(simulationData,statsData);
            //initalize the simulation
            theSim.Initialize();
            //run the simulation
            theSim.RunSimulation();
           
        }//End Method
        
        
        private void ViewSelection()
        {
            //check to see the users selection on the view type....
            if (rdoGraphical.Checked == true)
                //if they want to see graphics view call the graphic method
                GraphicsView();
            else
                //if they want to see the text view show the textview
                TextView();
        }//End Method

        private void GraphicsView()
        {
            //Show the graphics surface and hide all data grids except for the stats
            graphicsSurface.Show();
            OtherQueueDataGridView.Hide();
            StereoQueueDataGridView.Hide();
            CalanderDataGrid.Hide();
            lblCalanderDGV.Hide();

        }//End Method

        private void TextView()
        {
            //Hide the graphics surface and Show all data grids 
            graphicsSurface.Hide();
            OtherQueueDataGridView.Show();
            StereoQueueDataGridView.Show();
            CalanderDataGrid.Show();
            lblCalanderDGV.Show();

        }


    }
}
