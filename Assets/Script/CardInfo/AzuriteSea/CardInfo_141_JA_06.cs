using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_141_JA_06 : CardInfo
{
    public CardInfo_141_JA_06()
    {
        this.cardNo = "141_JA_06";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ジッパー";
        this.cardName2 = "すばしっこいおとり役";
        this.power = 2;
        this.toughness = 2;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.EriWelli;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Ward };
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.Chipmunk;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
