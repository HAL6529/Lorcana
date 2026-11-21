using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_176_JA_09 : CardInfo
{
    public CardInfo_176_JA_09()
    {
        this.cardNo = "176_JA_09";
        this.inkCost = 2;
        this.availableInk = false;
        this.cardName1 = "リトル・ジョン";
        this.cardName2 = "レジナルド公爵";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.CristianRomero;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.Fabled_vol2;
        this.title = EnumController.Title.RobinHood;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
