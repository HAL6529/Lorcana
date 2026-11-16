using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_144_JA_06 : CardInfo
{
    public CardInfo_144_JA_06()
    {
        this.cardNo = "144_JA_06";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "プリークリー";
        this.cardName2 = "科学分野の第一人者";
        this.power = 3;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.HeidiNeunhoffer;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Alien };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.LiloAndStitch;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
