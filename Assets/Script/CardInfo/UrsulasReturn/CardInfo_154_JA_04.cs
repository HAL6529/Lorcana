using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_154_JA_04 : CardInfo
{
    public CardInfo_154_JA_04()
    {
        this.cardNo = "154_JA_04";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "スカットル";
        this.cardName2 = "人間の専門家";
        this.power = 1;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.Kapik;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.TheLittleMermaid;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
