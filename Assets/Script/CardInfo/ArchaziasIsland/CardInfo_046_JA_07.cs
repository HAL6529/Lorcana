using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_046_JA_07 : CardInfo
{
    public CardInfo_046_JA_07()
    {
        this.cardNo = "046_JA_07";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ƒ^ƒiƒi";
        this.cardName2 = "•”‘°‚Ì’·˜V";
        this.power = 4;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.FilipeLaurentino;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.BrotherBear;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
