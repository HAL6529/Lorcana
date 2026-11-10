using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_022_JA_02 : CardInfo
{
    public CardInfo_022_JA_02()
    {
        this.cardNo = "022_JA_02";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "‚­‚µ‚á‚Ý";
        this.cardName2 = "ƒ€ƒYƒ€ƒY‰®";
        this.power = 1;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.KendallHale;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.SevenDwarfs };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.SnowWhiteAndTheSevenDwarfs;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
