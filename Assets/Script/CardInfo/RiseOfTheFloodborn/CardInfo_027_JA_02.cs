using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_027_JA_02 : CardInfo
{
    public CardInfo_027_JA_02()
    {
        this.cardNo = "027_JA_02";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "èóâ§";
        this.cardName2 = "å†à–Ç†ÇÈåNéÂ";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.EvaWidermann;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Queen };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.SnowWhiteAndTheSevenDwarfs;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
