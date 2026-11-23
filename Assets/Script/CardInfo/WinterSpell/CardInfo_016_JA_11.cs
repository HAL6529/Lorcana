using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_016_JA_11 : CardInfo
{
    public CardInfo_016_JA_11()
    {
        this.cardNo = "016_JA_11";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "ティモン";
        this.cardName2 = "雪玉ドロボー";
        this.power = 2;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JuanDiegoLeon;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.TheLionKing;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
