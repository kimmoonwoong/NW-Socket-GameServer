﻿using Server;
using ServerCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PacketHandler
{
    public static void C_ChatHandler(PacketSession session, IPacket packet)
    {
        C_Chat p = packet as C_Chat;
        ClientSession clientSession = session as ClientSession;
        GameRoom room = clientSession.room;
        if (room == null) return;

        room.Push(() => { room.Brodcast(clientSession, p.chat); });
    }
}
