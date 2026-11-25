using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_235_JA_13 : CardInfo
{
    public CardInfo_235_JA_13()
    {
        this.cardNo = "235_JA_13";
        this.inkCost = 7;
        this.availableInk = true;
        this.cardName1 = "マレフィセント＆ディアブロ";
        this.cardName2 = "悪の権化";
        this.power = 6;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.EricaDurso;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Team, EnumController.Class.Villain, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst, EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift5 };
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.SleepingBeauty;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}
