using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_116_JA_02 : CardInfo
{
    public CardInfo_116_JA_02()
    {
        this.cardNo = "116_JA_02";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "マザー・ゴーテル";
        this.cardName2 = "しわしわで性悪";
        this.power = 3;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.Koni;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.Tangled;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
