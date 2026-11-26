using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_042_JA_14 : CardInfo
{
    public CardInfo_042_JA_14()
    {
        this.cardNo = "042_JA_14";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "ヴィクトリアおばさん";
        this.cardName2 = "辛辣なご先祖様";
        this.power = 4;
        this.toughness = 7;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.AlibethZermeno;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.Coco;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
