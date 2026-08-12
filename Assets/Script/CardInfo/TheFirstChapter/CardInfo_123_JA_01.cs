using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_123_JA_01 : CardInfo
{
    public CardInfo_123_JA_01()
    {
        this.cardNo = "123_JA_01";
        this.inkCost = 8;
        this.availableInk = false;
        this.cardName1 = "スカー";
        this.cardName2 = "恥知らずな煽り屋";
        this.power = 6;
        this.toughness = 6;
        this.lore = 1;
        this.illustrator = "Jenna Gray";
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Villain, EnumController.Class.King };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Shift6 };
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.TheLionKing;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
