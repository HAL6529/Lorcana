using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_189_JA_01 : CardInfo
{
    public CardInfo_189_JA_01()
    {
        this.cardNo = "189_JA_01";
        this.inkCost = 7;
        this.availableInk = true;
        this.cardName1 = "ƒVƒ“ƒo";
        this.cardName2 = "‹AŠÒ‚µ‚½‰¤";
        this.power = 4;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = "Nicholas Kole";
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.King };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Challenger4 };
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.TheLionKing;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
