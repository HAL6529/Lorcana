using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_023_JA_08 : CardInfo
{
    public CardInfo_023_JA_08()
    {
        this.cardNo = "023_JA_08";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "キャンディ大王";
        this.cardName2 = "シュガー・ラッシュの悪夢";
        this.power = 3;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JosephBuenning;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.King, EnumController.Class.Racer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber, EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.WreckItRalph;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
