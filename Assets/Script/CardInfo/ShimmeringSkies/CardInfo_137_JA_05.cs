using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_137_JA_05 : CardInfo
{
    public CardInfo_137_JA_05()
    {
        this.cardNo = "137_JA_05";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "キャンディ大王";
        this.cardName2 = "シュガー・ラッシュの支配者";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.OttoParedes;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.King, EnumController.Class.Racer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.WreckItRalph;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
