using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

/*HEADER 
 * ||================================================================================================================================||
 * ||                                                PROGRAM: CALL CENTER - DISCRETE EVENT SIMULATOR                                 ||
 * ||                                                 CLASS: GraphicsDisplayObserver.cs                                              ||
 * ||                                                AUTHOR: DAMIEN GUYTON (GUYTODJ1)                                                ||
 * ||                                                 DATE: 14/07/2013                                                               ||
 * ||                                                                                                                                ||
 * || ______________________________________________________DESCRIPTION_____________________________________________________________ ||
 * || GraphicsDisplayObserver Class displays the the sim graphically as it receives  the data from the subjects method notification  ||                                                                                                        ||
 * ||================================================================================================================================||
 */
namespace GUYTODJ1_Call_Center_DES
{
    class GraphicsDisplayObserver:SimulationDisplays
    {
        Panel graphicsSurface;
        Graphics g;
        int width;
        int height;
        Brush greenBrush;
        Brush blueBrush;
        Brush redBrush;
        Brush yellowBrush;
        Font drawFont;
        SolidBrush drawBrush;
        Pen blackPen;
        Brush blackBrush;
        public GraphicsDisplayObserver(Object displayObject, ISimulationDataSubject simData)
            : base(displayObject, simData)
        {
            //Initalize variables
            width = 28;
            height = 28;
            //Creating the brushes for drawing 
            greenBrush = new SolidBrush(Color.PaleGreen);
            blueBrush = new SolidBrush(Color.PaleTurquoise);
            redBrush = new SolidBrush(Color.LightPink);
            yellowBrush = new SolidBrush(Color.LightGoldenrodYellow);
            //Create the font style to paint on the entity
            drawFont = new Font("Arial", 16);
            drawBrush = new SolidBrush(Color.Black);
            blackPen = new Pen(Color.Black, 2);
            blackBrush = new SolidBrush(Color.Silver);
            //cast the object to a panel
            this.graphicsSurface = (Panel)displayObject;
            g = graphicsSurface.CreateGraphics();                                                                                                                                                                                                                                                                                                                                         
            simData.AddObserver(this);
        }

        //----------------------------------------------------------------------------------------
        // Update Method | Parameters : Simulator
        //----------------------------------------------------------------------------------------
        public override void Update(Simulator sim)
        {
            //make the simCurrenState = to the simulate at the current moment upadte is called
            simCurrentState = sim;

            //displaythe data
            DisplayData();

        }//End Method

        //----------------------------------------------------------------------------------------
        // DisplayData Method | Parameters : N/A
        //----------------------------------------------------------------------------------------
        public override void DisplayData()
        {           
            // Create varriables to hold the entitys that are currently in the system
            Queue<Entity> StereoQueue = simCurrentState.theQueueManager.StereoQueue;
            Queue<Entity> OtherQueue = simCurrentState.theQueueManager.OtherQueue;
            List<Entity> StereoRepList = new List<Entity>();
            List<Entity> OtherRepList = new List<Entity>();
            Entity CallArriveEntity = null;
            Entity IVREntity = null;

            //Iterate over the calandar to find the call arrive entity
            foreach (SimulationEvent e in simCurrentState.MainCalandar.EventList)
            {
                if (e.eventType == eEventType.CallArrive)
                {
                    CallArriveEntity = e.EventEntity;
                }
            }

            //Itterate over the calandar to find the entity at the IVR
            foreach (SimulationEvent e in simCurrentState.MainCalandar.EventList)
            {
                if (e.eventType == eEventType.SwitchComplete)
                {
                    IVREntity = e.EventEntity;
                }
            }

            //Iterate through the clandar getting all the events that have a process complete event
            foreach (SimulationEvent e in simCurrentState.MainCalandar.EventList)
            {
               
                if (e.eventType == eEventType.ProcessingComplete)
                {
                    //switch on the entitys call type to pass them into the appropriate list
                    switch (e.EventEntity.EntityCallType)
                    {
                        case eCallType.StereoCall:
                            StereoRepList.Add(e.EventEntity);
                            break;

                        case eCallType.OtherCall:
                            OtherRepList.Add(e.EventEntity);
                            break;
                    }//End Switch
                }//End If
            }

            //Refresh the graphics surface
            graphicsSurface.Refresh();
            //Draw the Graphics area
            DrawGraphicsSurface();
            //draw stereo queue
            DrawStereoQueue(StereoQueue);
            //draw other queue
            DrawOtherQueue(OtherQueue);
            DrawStereoEntitysCurrentlyWithRep(StereoRepList);
            //draw entitys that are dealing with other rep
            DrawOtherEntitysCurrentlyWithRep(OtherRepList);
            //draw entity that is arriving
            DrawEntityArriving(CallArriveEntity);
            //draw entity that is at IVR
            DrawEntityAtIVR(IVREntity);
           
        }//End method

        //----------------------------------------------------------------------------------------
        // DrawGraphicsSurface Method | Parameters : N/A
        //----------------------------------------------------------------------------------------
        private void DrawGraphicsSurface()
        {
            int width = 30;
            int height = 30;
            //irv 
            int irvEntityX = 150;
            int irvEntityY = 130;
            //g.FillEllipse(blackBrush, irvEntityX, irvEntityY, width, height);
            g.DrawRectangle(blackPen, irvEntityX, irvEntityY, width, height);

            //stereo queue
            int stereoQueueX = 230;
            int stereoQueueY = 20;
            g.DrawRectangle(blackPen, stereoQueueX, stereoQueueY, 450, height);

            //other queue
            int otherQueueX = 230;
            int otherQueueY = 255;
            g.DrawRectangle(blackPen, otherQueueX, otherQueueY, 450, height);

            //stero reps
            int steroEntityInProcessX = 740;
            int stereoEntityInProcessY = 1;
            g.DrawRectangle(blackPen, steroEntityInProcessX, stereoEntityInProcessY, 30, 150);

            //other reps
            int otherEntityInProcessX = 740;
            int otherEntityInProcessY = 153;
            g.DrawRectangle(blackPen, otherEntityInProcessX, otherEntityInProcessY, 30, 150);
        }//End Method

        //----------------------------------------------------------------------------------------
        // DrawStereoQueue Method | Parameters : Queue<Entity>
        //----------------------------------------------------------------------------------------
        private void DrawStereoQueue(Queue<Entity> StereoQueue)
        {
            //declear the locaton co-ordinates
            int startStereoX = 230;
            int startStereoY = 20;

            foreach (Entity e in StereoQueue)
            {
                //Iterate through the entitys in queue and draw them
                string entityID = e.EntityID.ToString();
                g.FillEllipse(greenBrush, startStereoX, startStereoY, width, height);
                g.DrawString(entityID, drawFont, drawBrush, startStereoX, startStereoY);
                startStereoX += width;
            }


        }//End Method

        //----------------------------------------------------------------------------------------
        // DrawOtherQueue Method | Parameters : Queue<Entity>
        //----------------------------------------------------------------------------------------
        private void DrawOtherQueue(Queue<Entity> OtherQueue)
        {
            //declear the locaton co-ordinates
            int startOtherX = 230;
            int startOtherY = 255;

            //Iterate through the entitys in queue and draw them
            foreach (Entity e in OtherQueue)
            {
                string entityID = e.EntityID.ToString();
                g.FillEllipse(blueBrush, startOtherX, startOtherY, width, height);
                g.DrawString(entityID, drawFont, drawBrush, startOtherX, startOtherY);
                startOtherX += width;
            }
        }//End Method

        //----------------------------------------------------------------------------------------
        // DrawStereoEntitysCurrentlyWithRep Method | Parameters : List<Entity>
        //----------------------------------------------------------------------------------------
        private void DrawStereoEntitysCurrentlyWithRep(List<Entity> StereoRepList)
        {
            //declear the locaton co-ordinates
            int startStereoRepX = 740;
            int startStereoRepY = 1;
            foreach (Entity e in StereoRepList)
            {
                //Iterate through the entitys dealing with the rep and draw them
                string entityID = e.EntityID.ToString();
                g.FillEllipse(greenBrush, startStereoRepX, startStereoRepY, width, height);
                g.DrawString(entityID, drawFont, drawBrush, startStereoRepX, startStereoRepY);
                startStereoRepY += width;

            }


        }//End Method

        //----------------------------------------------------------------------------------------
        // DrawOtherEntitysCurrentlyWithRep Method | Parameters :  List<Entity>
        //----------------------------------------------------------------------------------------
        private void DrawOtherEntitysCurrentlyWithRep(List<Entity>OtherRepList)
        {

            //declear the locaton co-ordinates
            int startOtherRepX = 740;
            int startOtherRepY = 153;
            //Iterate through the entitys dealing with the rep and draw them
            foreach (Entity e in OtherRepList)
            {

                string entityID = e.EntityID.ToString();
                g.FillEllipse(blueBrush, startOtherRepX, startOtherRepY, width, height);
                g.DrawString(entityID, drawFont, drawBrush, startOtherRepX, startOtherRepY);
                startOtherRepY += width;

            }

        }//End Method

        //----------------------------------------------------------------------------------------
        // DrawEntityArriving Method | Parameters : Entity
        //----------------------------------------------------------------------------------------
        private void DrawEntityArriving(Entity CallArriveEntity)
        {
            //check to make sure there is and entity with an arrive event
            if (CallArriveEntity != null)
            {
                //declear the locaton co-ordinates
                int arriveEntityX = 45;
                int arriveEntityY = 130;

                //draw the Entity
                string entityID = CallArriveEntity.EntityID.ToString();
                g.FillEllipse(yellowBrush, arriveEntityX, arriveEntityY, width, height);
                g.DrawString(entityID, drawFont, drawBrush, arriveEntityX, arriveEntityY);
            }
        }//End Method

        //----------------------------------------------------------------------------------------
        // DrawEntityAtIVR Method | Parameters : Entity
        //----------------------------------------------------------------------------------------
        private void DrawEntityAtIVR(Entity IVREntity)
        {
            //check to make sure there is and entity with complete switch event
            if (IVREntity != null)
            {
                //declear the locaton co-ordinates
                int irvEntityX = 150;
                int irvEntityY = 130;

                //draw the entity 
                string entityID = IVREntity.EntityID.ToString();
                g.FillEllipse(redBrush, irvEntityX, irvEntityY, width, height);
                g.DrawString(entityID, drawFont, drawBrush, irvEntityX, irvEntityY);
            }

        }//End Method
    }

}
