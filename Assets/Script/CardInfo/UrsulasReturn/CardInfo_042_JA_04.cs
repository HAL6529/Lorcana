using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_042_JA_04 : CardInfo
{
    public CardInfo_042_JA_04()
    {
        this.cardNo = "042_JA_04";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "ƒGƒ‹ƒT";
        this.cardName2 = "—’‚ð’Ç‚¤ŽÒ";
        this.power = 1;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MarianaMoreno;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Queen, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Frozen;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
