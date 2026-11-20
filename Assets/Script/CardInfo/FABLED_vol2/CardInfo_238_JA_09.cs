using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_238_JA_09 : CardInfo
{
    public CardInfo_238_JA_09()
    {
        this.cardNo = "238_JA_09";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "リロ";
        this.cardName2 = "さいこうにすごい探検家";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.KuyaJaypi;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.Fabled_vol2;
        this.title = EnumController.Title.LiloAndStitch;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}
