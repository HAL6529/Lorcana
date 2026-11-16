using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_137_JA_06 : CardInfo
{
    public CardInfo_137_JA_06()
    {
        this.cardNo = "137_JA_06";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ベン";
        this.cardName2 = "エキセントリックなロボット";
        this.power = 4;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.Gwawi;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Robot, EnumController.Class.Pirate };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Support };
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.TreasurePlanet;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
