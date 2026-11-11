using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_184_JA_05 : CardInfo
{
    public CardInfo_184_JA_05()
    {
        this.cardNo = "184_JA_05";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "イズマ";
        this.cardName2 = "不当な扱いにイライラ";
        this.power = 1;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.CarlosGomesCabral;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Villain, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.TheEmperorsNewGroove;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
