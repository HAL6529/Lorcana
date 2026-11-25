using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_138_JA_13 : CardInfo
{
    public CardInfo_138_JA_13()
    {
        this.cardNo = "138_JA_13";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "IT'S GONNA BE GREAT!";
        this.cardName2 = "イッツ・ガナ・ビー・グレート！";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.SerenaWade;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.WinnieThePooh;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.Common;
    }
}
