using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_051_JA_14 : CardInfo
{
    public CardInfo_051_JA_14()
    {
        this.cardNo = "051_JA_14";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ママ・イメルダ";
        this.cardName2 = "頑固一徹なご先祖様";
        this.power = 5;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.MarianaMoreno;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Mentor };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.Coco;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
