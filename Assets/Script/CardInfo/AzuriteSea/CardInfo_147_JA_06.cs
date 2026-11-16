using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_147_JA_06 : CardInfo
{
    public CardInfo_147_JA_06()
    {
        this.cardNo = "147_JA_06";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "サワー・ビル";
        this.cardName2 = "酸っぱい側近";
        this.power = 2;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.MikeMuAndLivioCacciatore;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.WreckItRalph;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
