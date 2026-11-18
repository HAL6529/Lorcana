using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_209_JA_08 : CardInfo
{
    public CardInfo_209_JA_08()
    {
        this.cardNo = "209_JA_08";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "バンビ";
        this.cardName2 = "小さな王子さま";
        this.power = 1;
        this.toughness = 1;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.AubreyArcher;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Prince };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.Bambi;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}
