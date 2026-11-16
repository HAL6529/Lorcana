using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_045_JA_06 : CardInfo
{
    public CardInfo_045_JA_06()
    {
        this.cardNo = "045_JA_06";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "イアーゴ";
        this.cardName2 = "オウム返るオウム";
        this.power = 4;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.CamKendell;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.Aladdin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
