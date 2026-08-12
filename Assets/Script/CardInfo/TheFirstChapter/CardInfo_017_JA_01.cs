using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_017_JA_01 : CardInfo
{
    public CardInfo_017_JA_01()
    {
        this.cardNo = "017_JA_01";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "プンバァ";
        this.cardName2 = "なかよしイボイノシシ";
        this.power = 3;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = "Jenna Gray";
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.TheLionKing;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
