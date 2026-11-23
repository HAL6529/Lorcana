using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_071_JA_11 : CardInfo
{
    public CardInfo_071_JA_11()
    {
        this.cardNo = "071_JA_11";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ビッグ・ママ";
        this.cardName2 = "かしこくおだやか";
        this.power = 3;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.EllieHorie;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Ward };
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.TheFoxAndTheHound;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
