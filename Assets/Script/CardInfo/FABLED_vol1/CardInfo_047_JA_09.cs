using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_047_JA_09 : CardInfo
{
    public CardInfo_047_JA_09()
    {
        this.cardNo = "047_JA_09";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ティモシー";
        this.cardName2 = "空飛ぶゾウのせんせい";
        this.power = 1;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.GraceTran;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Mentor};
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.Fabled_vol1;
        this.title = EnumController.Title.Dumbo;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
