using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locatronics
{
    // organizer > racks > cells > baskets > chambers
    public class organizer
    {
        // @todo Make an array of racks
        public List<rack> racks = new List<rack>();

        public organizer()
        {
            setupR1();
            //setupR2();
            //setupR3();
            //setupR4();
        }

        public void setupR1()
        {
            rack r1 = new rack();
            racks.Add(r1);

            // ??
            r1.cell(111, "Black Red Soft Plastic Coated Testing Probe Aligator Clips Crocodile P2001");
            r1.cell(112, "5.08mm 2 Pin Connect Terminal Screw Terminal Connector KF301-2P");
            r1.cell(113, "Pitch jumper shorted cap&Headers & Wire Housings 2.54MM SHUNT");
            r1.cell(114, "T type 9V DC Battery Power Cable Barrel Jack Connector");
            r1.cell(115, "Snap on 9V Battery Holder Clip Connector Hard Shell 10CM Cable Lead");
            r1.cell(116, "Plastic ABS Enclosure Protective Case shell Transparent For UNO R3 Arduino");

            // LEDs and Diodes
            r1.cell(121, "Red LED");
            r1.cell(122, "Green LED");
            r1.cell(123, "Blue LED");
            r1.cell(124, "RGB Common Cathode LED");
            r1.cell(125, "RGB Common Anode LED");
            r1.cell(126, "3mm LED Light White Yellow Red Blue Green Assortment Diodes");
            r1.cell(127, "IR Emitter TSAL6100 6100 Emitter IR 5Mm Hi Eff 940nm ");
            r1.cell(128, "Laser Diode LED");
            r1.cell(129, "1A 1000V Diode 1N4007 IN4007 DO-41 Rectifier Diodes");

            // Resistors - Variable Values
            r1.cell(131, "Resistors - Low");
            r1.cell(132, "Resistors - Medium");
            r1.cell(133, "Resistors - High");

            // Capacitors - Variable Values
            r1.cell(141, "Capacitors - Low");
            r1.cell(142, "Capacitors - Medium");
            r1.cell(143, "Capacitors - High");

            // Sensors and Switches
            r1.cell(151, "LDR 5mm");
            r1.cell(152, "IR Sensor HS0038B HS0038 Sip3 Infrared Receiver To-92 Ir Receiver New Diy Ic I");
            r1.cell(153, "Reed Switch");
            r1.cell(154, "DIP Switch");
            r1.cell(155, "Push Button Switch");

            // External Devices
            r1.cell(161, "Magnets");
            r1.cell(162, "RTC Real Time Clock");
            r1.cell(163, "Crystal Oscillator");
            r1.cell(164, "FT232RL FTDI Serials Adapter Module");
            r1.cell(165, "Wireless Adapter Network LAN Card 802.11n/g/b OY");
            r1.cell(166, "USB 3.0 Female Header to 9 Pin USB 2.0 Male Motherboard adapter Cable");

            // Wiring
            r1.cell(171, "Solderless MB-102 MB102 Breadboard 830 Tie Point PCB BreadBoard");
            r1.cell(172, "MB102 Breadboard Power Supply Module 3.3V/5V For Arduino Breadboard");
            r1.cell(173, "Jumper Cables 120pcs Dupont Wire Male to Male + Male to Female + Female to Female Jumper Cable");
            r1.cell(174, "Breadboard 400 Contacts");
            r1.cell(175, "GPIO Ribbon Cable");

            // Computer Boards
            r1.cell(181, "Arduino Uno Board");
            r1.cell(182, "Arduino Mini Board");
            r1.cell(183, "Raspberry Pi Board");

            // Connectors
            r1.cell(191, "Male Header Pin");
            r1.cell(192, "Female Header Pin");
            r1.cell(193, "USB Solder");
            r1.cell(194, "Normal Solder");
            r1.cell(195, "Heat Shrink Tube");

            // Integrated Circuits
            r1.cell(201, "ATMEGA328P-PU");
            r1.cell(202, "NE555");
            r1.cell(203, "SN74HC595N 74HC595 8-Bit Shift Register DIP-16 IC");
            r1.cell(204, "BC547 TO-92 NPN 45V 0.1A Transistor");

            // Soldering
            r1.cell(211, "Cable Tester+Crimp Crimper");
            r1.cell(212, "Tin Lead Rosin Core Solder Soldering Welding Wire FLUX 2.0%");
            r1.cell(213, "Rainbow Ribbon IDC Cable Wire Rainbow Cable");
            r1.cell(214, "Multi Tester AC DC Voltmeter Ohmmeter Electrical Digital Multimeter DT-830B");
            r1.cell(215, "DIP IC Socket PCB Mount Connector");
            r1.cell(216, "100m Red Magnet Wire 0.2mm Enameled Copper Wire Round Magnetic Coil Winding");

            // Power Tools
            r1.cell(221, "4 Channel Relay Module With Optocoupler");
            r1.cell(223, "5V 1/2/4/6/8 Channel Relay Board Module Optocoupler LED for Arduino PiC ARM AVR");
            r1.cell(224, "L317 LM317 LM317T TO-220 Voltage Regulator 1.2V To 37V 1.5A");
            r1.cell(225, "5 Way Spring Lever Terminal Block Electric Cable Wire Connector PCT-215");
            r1.cell(226, "AC Max 110~250V 2A In-line ON/OFF Table Lamp Desk Bed Light Cord Switch");
            r1.cell(227, "Prototype Paper PCB Universal Board");
            r1.cell(228, "Cute Flexible USB LED Light Mini Lamp For Computer Notebook Laptop PC Power Bank");

            // ??
            r1.cell(231, "UID Changeable Sector 0 Block 0 Writable 13.56Mhz RFID Proximity Smart Card");
            r1.cell(232, "RFID IC Keyfobs Key Tags Token NFC TAG Keychain 13.56MHz for Arduino");
            r1.cell(233, "125Khz USB RFID Contactless Proximity Sensor Smart ID Card Reader EM4100");
            r1.cell(234, "Network Cable Plug Connectors RJ45 Modular Female Couplers Module");
            r1.cell(235, "2000DPI Mice Optical Mouse Cordless USB Receiver PC Laptop Wireless Mice - Red");
            r1.cell(236, "2000DPI Mice Optical Mouse Cordless USB Receiver PC Laptop Wireless Mice - Yellow");

            // Tools
            // cutter, cramper
        }

        public List<basket> search(string component)
        {
            component = component.ToUpper();

            // in each racks
            // if basket contains partial component name
            // install

            // for each racks
            List<basket> search = new List<basket>();
            foreach (rack rack in racks)
            {
                foreach (basket b in rack.baskets)
                {
                    if (b.contents.Contains(component))
                    {
                        search.Add(b);
                    }
                }
            }

            return search;
        }

        public List<string> preview(string component)
        {
            component = component.ToUpper();

            List<string> names = new List<string>();
            // for each items, if partial names matches, return strings
            foreach (rack rack in racks)
            {
                foreach (basket b in rack.baskets)
                {
                    if (b.contents.Contains(component))
                    {
                        names.Add(b.contents);
                    }
                }
            }


            return names;
        }
    }
}
